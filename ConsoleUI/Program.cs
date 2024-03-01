using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

CourseManager courseManager = new CourseManager(new EfCourseDal());