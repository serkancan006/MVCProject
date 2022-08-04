using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : ıImageFileService
    {
        ıImageFileDal _imageFileDal;

        public ImageFileManager(ıImageFileDal headingDal)
        {
            _imageFileDal = headingDal;
        }

        public List<ImageFile> GetList()
        {
            return _imageFileDal.List();
        }


    }
}
