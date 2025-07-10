using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.EntityLayer.Concrete;

namespace Hotelier.BusinessLayer.Concrete
{
    public class TestimaonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;
        public TestimaonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }
        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
