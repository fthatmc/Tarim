using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repository;
using DataAccesLayer.Context;
using EntitiyLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Entity
{
    public class EfAnnouncemenetDal : GenericRepository<Announcemenet>, IAnnouncementDal
    {
        public void AnnouncementStatusToFalse(int id)
        {
            var context = new AgricultureContext();
            Announcemenet p = context.Announcements.Find(id);
            p.Status = false;
            context.SaveChanges();
        }

        public void AnnouncementStatusToTrue(int id)
        {
            var context = new AgricultureContext();
            Announcemenet p = context.Announcements.Find(id);
            p.Status = true;
            context.SaveChanges();
        }
    }
}
