using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repository;
using EntitiyLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Entity
{
    public class EfAddressDal : GenericRepository<Address>,IAddressDal
    {
    }
}
