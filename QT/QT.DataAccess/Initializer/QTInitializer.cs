using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using QT.DataAccess.Context;
using QT.Models;
using QT.Repository.Pattern.Ef6;

namespace QT.DataAccess.Initializer
{
    public enum InitializationStrategy
    {
        Default = 0,
        DropCreateAlways = 1,
        DropCreateIfModelChanges = 2,
        CreateIfNotExists = 3
    }

    public class QTInitializer:IDatabaseInitializer<QTContext>
    {
         private readonly IDatabaseInitializer<QTContext> _initializer;

        public QTInitializer(QTContext QTContext)
        {
            _initializer = MakeInitializer(InitializationStrategy.DropCreateIfModelChanges);
        }

        private static IDatabaseInitializer<QTContext> MakeInitializer(InitializationStrategy initializationStrategy)
        {
            switch (initializationStrategy)
            {
                case InitializationStrategy.CreateIfNotExists:
                    return new CreateDatabaseIfNotExists<QTContext>();
                case InitializationStrategy.DropCreateAlways:
                    return new DropCreateDatabaseAlways<QTContext>();
                case InitializationStrategy.DropCreateIfModelChanges:
                    return new DropCreateDatabaseIfModelChanges<QTContext>();
            }

#if DEBUG
            return new DropCreateDatabaseIfModelChanges<QTContext>(); 
                //DropCreateDatabaseAlways<QTContext>();
#else
            return new DropCreateDatabaseIfModelChanges<QTContext>();
#endif
        }

        private static IDatabaseInitializer<QTContext> MakeInitializer(string str)
        {
            InitializationStrategy initializationStrategy;

            if (!Enum.TryParse(str, out initializationStrategy))
                initializationStrategy = InitializationStrategy.Default;

            return MakeInitializer(initializationStrategy);
        }

        public void InitializeDatabase(QTContext context)
        {
            try
            {
                if (!context.Database.Exists())
                {
                    _initializer.InitializeDatabase(context);
                    Seed(context);

                    //context.SaveChanges();
                }
                //if (!context.Database.CompatibleWithModel(true))
                //{
                //    context.Database.Delete();
                //    _initializer.InitializeDatabase(context);
                //    Seed(context);

                //    //context.SaveChanges();
                //}
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }

        private void Seed(QTContext context)
        {
            var listSanPhams = new List<SanPham>()
			{
				
			};

            var unitOfWork = new UnitOfWork(context);
            //context.IvrLanguageCodes.AddOrUpdate(listLanguageCodes);
            unitOfWork.Repository<SanPham>().InsertRange(listSanPhams);
            unitOfWork.SaveChanges();
        }
    }
}
