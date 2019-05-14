using QLQuanCafe.Data.Infrastructure;
using QLQuanCafe.Data.Repositories;
using QLQuanCafe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Service
{
    public interface ITableService
    {
        void Add(Table table);
        void Delete(Table table);
        void Update(Table table);
        IEnumerable<Table> GetAll();
        IEnumerable<Table> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Table> GetAllByParentID(int areaId);
        IEnumerable<Table> GetAllByAreaID(int areaID, int page, int pageSize, out int totalRow);
        Table GetById(int id);
        void SaveChange();

    }
    public class TableService : ITableService
    {
        ITableRepository _tableRepository;
        IUnitOfWork _unitOfWork;
        public TableService(ITableRepository tableRepository, IUnitOfWork unitOfWork)
        {
            _tableRepository = tableRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Table table)
        {
            _tableRepository.Add(table);
        }

        public void Delete(Table table)
        {
            _tableRepository.Delete(table);
        }

        public IEnumerable<Table> GetAll()
        {
            return _tableRepository.GetAll(new string[] { "Area" });
        }

        public IEnumerable<Table> GetAllByAreaId(int areaID, int page, int pageSize, out int totalRow)
        {
            return _tableRepository.GetMultiPaging(x => x.Status && x.AreaID == areaID, out totalRow, page, pageSize, new string[] { "Area" });
        }

        public IEnumerable<Table> GetAllByAreaID(int areaID, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Table> GetAllByParentID(int areaId)
        {
            return _tableRepository.GetMulti(x => x.Status && x.AreaID == areaId);
        }

        public IEnumerable<Table> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _tableRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Table GetById(int id)
        {
            return _tableRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Table table)
        {
            _tableRepository.Update(table);
        }
    }
}
