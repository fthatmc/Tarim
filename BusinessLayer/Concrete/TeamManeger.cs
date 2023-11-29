using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Entity;
using EntitiyLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeamManeger : ITeamService
    {
        private readonly ITeamDal _teamDal;

        public TeamManeger(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public void Delete(Team t)
        {
            _teamDal.Delete(t);
        }

        public Team GetById(int id)
        {
            return _teamDal.GetById(id);
        }

        public List<Team> GetListAll()
        {
            return _teamDal.GetListAll();
        }

        public void Insert(Team t)
        {
            _teamDal.Add(t);
        }

        public void Update(Team t)
        {
            _teamDal.Update(t);
        }
    }
}
