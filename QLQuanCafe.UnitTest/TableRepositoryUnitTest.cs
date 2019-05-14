using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLQuanCafe.Data.Infrastructure;
using QLQuanCafe.Data.Repositories;
using QLQuanCafe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.UnitTest
{
    [TestClass]
    public class TableRepositoryUnitTest
    {
        IDbFactory dbFactory;
        IUnitOfWork unitOfWork;
        ITableRepository objecRepository;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objecRepository = new TableRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);

        }
        [TestMethod]
        public void Table_Repository_Create()
        {
            Table table = new Table();
            table.ID = 1;
            table.Name = "Table 1";
            table.Status = true;
            table.UpdataBy = "Henry";
            var result = objecRepository.Add(table);

            Assert.AreEqual(1, result.ID);
            Assert.IsNotNull(result);
        }
    }
}
