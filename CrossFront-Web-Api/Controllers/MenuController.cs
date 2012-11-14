using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using CrossFront_Web_Api.Models;

namespace CrossFront_Web_Api.Controllers
{
    public class MenuController : ApiController
    {
        private MenuContext db = new MenuContext();

        // GET api/Menu
        public IEnumerable<MenuItem> GetMenuItems()
        {

            //in a real app this would be generated from the database using POCO and code first approach
            //return db.MenuItems.AsEnumerable();

            List<MenuItem> Menu = new List<MenuItem>() {
                new MenuItem { id = 1, text = "goto page #one", url = "#one" }, 
                new MenuItem { id = 2, text = "goto page #two", url = "#two" },
                new MenuItem { id = 1, text = "crossfront on github", url = "https://github.com/ntheile/CrossFront" },
                new MenuItem { id = 1, text = "crossfront on appharbor", url = "http://crossfront.apphb.com" }

                
             };
            
            IEnumerable<MenuItem> M = Menu.AsEnumerable();
            return M;

            //note to self - backbone.js collections are like IEnumerables
            
        }

        //// GET api/Menu/5 
        //public MenuItem GetMenuItem(int id)
        //{
        //    MenuItem menuitem = db.MenuItems.Find(id);
        //    if (menuitem == null)
        //    {
        //        throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
        //    }

        //    return menuitem;
        //}

        //// PUT api/Menu/5
        //public HttpResponseMessage PutMenuItem(int id, MenuItem menuitem)
        //{
        //    if (ModelState.IsValid && id == menuitem.id)
        //    {
        //        db.Entry(menuitem).State = EntityState.Modified;

        //        try
        //        {
        //            db.SaveChanges();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            return Request.CreateResponse(HttpStatusCode.NotFound);
        //        }

        //        return Request.CreateResponse(HttpStatusCode.OK);
        //    }
        //    else
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest);
        //    }
        //}

        //// POST api/Menu
        //public HttpResponseMessage PostMenuItem(MenuItem menuitem)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.MenuItems.Add(menuitem);
        //        db.SaveChanges();

        //        HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, menuitem);
        //        response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = menuitem.id }));
        //        return response;
        //    }
        //    else
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest);
        //    }
        //}

        //// DELETE api/Menu/5
        //public HttpResponseMessage DeleteMenuItem(int id)
        //{
        //    MenuItem menuitem = db.MenuItems.Find(id);
        //    if (menuitem == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound);
        //    }

        //    db.MenuItems.Remove(menuitem);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound);
        //    }

        //    return Request.CreateResponse(HttpStatusCode.OK, menuitem);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}