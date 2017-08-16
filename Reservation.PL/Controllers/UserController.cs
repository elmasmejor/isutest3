using PagedList;
using Reservation.BL;
using Reservation.Entities;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Reservation.PL.Controllers
{
    public class UserController : Controller
    {
        private readonly UserLogic _businessLogic;

        public UserController()
        {
            _businessLogic = new UserLogic();
            //businessLogic.InitializeDb();
        }

        public ActionResult Create()
        {
            ViewBag.Name = "Create an User";
            ViewBag.UserTypes = _businessLogic.GetUseTypes();
            return View();
        }

        public ActionResult DeleteAction(int id)
        {
            _businessLogic.DeleteUser(id);
            //Response.StatusCode = (int)HttpStatusCode.OK;
            //Response.End();
            //return new EmptyResult();
            return RedirectToAction("List");
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Name = "Edit an User";
            var toEdit = _businessLogic.GetUser(id);
            if (toEdit == null)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
                Response.End();
                return new EmptyResult();
            }

            ViewBag.UserTypes = _businessLogic.GetUseTypes();
            //ViewBag.User = toEdit;
            return View(toEdit);
        }

        [HttpPost]
        public ActionResult EditAction(User user)
        {
            if (_businessLogic.Edit(user))
            {
                Response.StatusCode = (int)HttpStatusCode.OK;
                Response.End();
                return new EmptyResult();
            }

            Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            Response.End();
            return new EmptyResult();
        }

        public ActionResult List(int page = 1, int pageSize = 10, bool sort = false, string field = "date", bool asc = false)
        {
            PagedList<User> userPagedList = null;
            if (sort)
            {
                if (field == "date")
                {
                    var users = asc ?
                     _businessLogic.GetUsers().OrderBy(u => u.Dob) :
                _businessLogic.GetUsers().OrderByDescending(u => u.Dob);

                    userPagedList = new PagedList<User>(users, page, pageSize);
                }
            }
            else
            {
                var users = _businessLogic.GetUsers();
                userPagedList = new PagedList<User>(users, page, pageSize);
            }

            ViewBag.Name = "User List";
            ViewBag.Message = "Message from list";
            return View(userPagedList);
        }

        [HttpPost]
        public ActionResult Save(User user)
        {
            if (_businessLogic.AddUser(user))
            {
                Response.StatusCode = (int)HttpStatusCode.OK;
                Response.End();
                return new EmptyResult();
            }

            Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            Response.End();
            return new EmptyResult();
        }
    }
}