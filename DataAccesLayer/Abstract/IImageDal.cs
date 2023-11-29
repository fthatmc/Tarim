using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image = EntitiyLayer.Models.Image;

namespace DataAccesLayer.Abstract
{
    public interface IImageDal : IGenericDal<Image>
    {
    }
}
