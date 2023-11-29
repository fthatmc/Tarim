using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntitiyLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncemenetService
    {
        private readonly IAnnouncementDal _announcementDAL;

        public AnnouncementManager(IAnnouncementDal announcementDAL)
        {
            _announcementDAL = announcementDAL;
        }

        public void AnnouncementStatusToFalse(int id)
        {
             _announcementDAL.AnnouncementStatusToFalse(id);
        }

        public void AnnouncementStatusToTrue(int id)
        {
            _announcementDAL.AnnouncementStatusToTrue(id);
        }

        public void Delete(Announcemenet t)
        {
            _announcementDAL.Delete(t);
        }

        public Announcemenet GetById(int id)
        {
            return _announcementDAL.GetById(id);
        }

        public List<Announcemenet> GetListAll()
        {
            return _announcementDAL.GetListAll();
        }

        public void Insert(Announcemenet t)
        {
            _announcementDAL.Add(t);
        }

        public void Update(Announcemenet t)
        {
            _announcementDAL.Update(t);
        }
    }
}
