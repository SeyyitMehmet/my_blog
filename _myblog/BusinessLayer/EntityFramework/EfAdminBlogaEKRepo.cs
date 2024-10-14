using DataAcsessLayer.Abstract;
using DataAcsessLayer.Repositories;
using Entitylayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EntityFramework
{
    public class EfAdminBlogaEKRepo: genericReopsitory<AdminBlogaEK>, IAdminBlogaEKDal
    {
    }
}
