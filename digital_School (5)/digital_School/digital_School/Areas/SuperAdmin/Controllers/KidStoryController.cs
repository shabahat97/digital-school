﻿using digital_School.Models;
using digital_School.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace digital_School.Areas.SuperAdmin.Controllers
{
    public class KidStoryController : Controller
    {
        Digital_SchoolEntities2 db = new Digital_SchoolEntities2();
        // GET: SuperAdmin/KidStory
        [HttpGet]
        public ActionResult viewKidStory()
        {

            if (Session["Ad"] == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });

            }

            var user = Convert.ToInt32(Session["Ad"]);
            var data = db.KidsStories.Where(x => x.UserId == user && x.RoleId == 1).ToList();

            return View(data);


        }
        [HttpGet]
        public ActionResult kidStor()
        {
            if (Session["Ad"] == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });
            }
            List<KidsStoryType> list = db.KidsStoryTypes.ToList();
            ViewBag.storytypelist = new SelectList(list, "KidsStoryTypeId", "KidsStoryName");

            return View();
        }
        [HttpPost]
        [ValidateInput(false)]

        public ActionResult kidStor(tbl_KidStory kid)
        {
            try
            {

                List<KidsStoryType> list = db.KidsStoryTypes.ToList();
                ViewBag.storytypelist = new SelectList(list, "KidsStoryTypeId", "KidsStoryName");
                KidsStory kd = new KidsStory();

                string filename = Path.GetFileNameWithoutExtension(kid.UserImageFIle.FileName);
                string extension = Path.GetExtension(kid.UserImageFIle.FileName);
                filename = DateTime.Now.ToString("yymmssff") + extension;
                kd.imgPath = "~/FrontEnd/Images/KidStoryImage/" + filename;
                //image ko folder me save krwanay ke leye
                filename = Path.Combine(Server.MapPath("~/FrontEnd/Images/KidStoryImage/"), filename);
                kid.UserImageFIle.SaveAs(filename);
                kd.CreatedDate = DateTime.Now;
                kid.Role_Id = Convert.ToInt32(Session["RoleId"]);
                kd.longDes = kid.longDes;
                kd.shortDes = kid.shortDes;
                kd.StoryTypeId = kid.StoryTypeId;
                kid.UserId = Convert.ToInt32(Session["Ad"]);
                kd.statusId = 2;
                kd.StoryTitle = kid.StoryTitle;
                db.KidsStories.Add(kd);

                db.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = "Data Submitted";

            }
            catch (Exception ex)
            {
                ViewBag.Message = "Not Submitted";
                return View();
            }

            return View();
        }

        [HttpGet]
        public ActionResult kidStoryType()
        {
            if (Session["Ad"] == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });

            }
            return View();
        }

        [HttpPost]
        public ActionResult kidStoryType(tbl_kidStoryTypeValidation kid)
        {
            try
            {
                KidsStoryType kidtype = new KidsStoryType();
                kidtype.KidsStoryName = kid.KidsStoryName;
                db.KidsStoryTypes.Add(kidtype);
                db.SaveChanges();
                ModelState.Clear();
                ViewBag.Message = "Data Submitted";

            }
            catch (Exception ex)
            {
                ViewBag.Message = "Not Submitted";
                return View();
            }
            return View();

        }


        //[HttpGet]
        //public ActionResult updateKidStory(int id)
        //{
        //    if (Session["Ad"] == null)
        //    {
        //        return RedirectToAction("login", "Home", new { area = "" });
        //    }
        //    List<KidsStoryType> list = db.KidsStoryTypes.ToList();
        //    ViewBag.storytypelist = new SelectList(list, "KidsStoryTypeId", "KidsStoryName");

        //    var data = db.KidsStories.Where(x => x.StoryId == id).First();


        //    return View(data);

        //}
        //[HttpPost]
        //[ValidateInput(false)]
        //public ActionResult updateKidStory(KidsStory da, int id)
        //{

        //    try
        //    {
        //        List<KidsStoryType> list = db.KidsStoryTypes.ToList();
        //        ViewBag.storytypelist = new SelectList(list, "KidsStoryTypeId", "KidsStoryName");

        //        var data = db.KidsStories.Where(x => x.StoryId == id).First();

        //        if (data != null)
        //        {

        //            data.StoryTypeId = da.StoryTypeId;
        //            data.StoryTitle = da.StoryTitle;
        //            data.shortDes = da.shortDes;
        //            data.longDes = da.longDes;

        //            db.Entry(data).State = EntityState.Modified;
        //            db.SaveChanges();
        //            ViewBag.Message = "Data Successfully Updated";
        //            ModelState.Clear();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = "Not Submitted";
        //        return View();
        //    }
        //    return RedirectToAction("viewKidStory", "Home");



        //}
        [HttpGet]
        public ActionResult updateKidStory(int id)

        {
            if (Session["Ad"] == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });

            }
            List<KidsStoryType> list = db.KidsStoryTypes.ToList();
               ViewBag.storytypelist = new SelectList(list, "KidsStoryTypeId", "KidsStoryName");

            //int userid = Convert.ToInt32((Session["Ad"]));
            //var sab = db.KidsStories.Find(userid);
            
            var data = db.KidsStories.Where(x => x.StoryId == id).First();
            Session["imgPath"] = data.imgPath;
            return View(data);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult updateKidStory(tbl_KidStory sa , int id)

        {
            if (Session["Ad"] == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });

            }
            List<KidsStoryType> list = db.KidsStoryTypes.ToList();
            ViewBag.storytypelist = new SelectList(list, "KidsStoryTypeId", "KidsStoryName");

            try
            {
                KidsStory kid = new KidsStory();
                //int userid = Convert.ToInt32((Session["Ad"]));

                //var l = db.loginTables.FirstOrDefault(t => t.UserId == userid);

                if (ModelState.IsValid)
                {
                    if (sa.UserImageFIle != null)
                    {

                        //if (l != null)
                        //{

                        //    l.UserId = userid;
                        //    l.Name = sa.ad_name;
                        //    l.Password = sa.password;
                        //    l.Email = sa.ad_email;
                        //    l.RoleID = 1;
                        //    db.Entry(l).State = EntityState.Modified;

                        //    db.SaveChanges();
                        //}
                        string filename = Path.GetFileNameWithoutExtension(sa.UserImageFIle.FileName);
                        string extension = Path.GetExtension(sa.UserImageFIle.FileName);
                        filename = DateTime.Now.ToString("yymmssff") + extension;




                        kid.imgPath = "~/FrontEnd/Images/KidStoryImage/" + filename;
                        kid.StoryId = id;
                        kid.StoryTitle = sa.StoryTitle;
                        kid.shortDes = sa.shortDes;
                        kid.longDes = sa.longDes;
                        kid.RoleId = Convert.ToInt32(Session["RoleId"]);
                        kid.UserId = Convert.ToInt32(Session["Ad"]);

                        kid.statusId = 2;
                        kid.StoryTypeId = sa.StoryTypeId;

                        kid.CreatedDate = DateTime.Now;


                        if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png")
                        {
                            if (sa.UserImageFIle.ContentLength <= 1000000)
                            {
                                db.Entry(kid).State = EntityState.Modified;



                                string oldImgPath = Request.MapPath(Session["imgPath"].ToString());

                                if (db.SaveChanges() > 0)
                                {
                                    filename = Path.Combine(Server.MapPath("~/FrontEnd/Images/KidStoryImage/"), filename);
                                    sa.UserImageFIle.SaveAs(filename);
                                    if (System.IO.File.Exists(oldImgPath))
                                    {
                                        System.IO.File.Delete(oldImgPath);
                                    }


                                    ViewBag.Message = "Data Updated";
                                    return RedirectToAction("viewKidStory");
                                }
                            }
                            else
                            {
                                ViewBag.msg = "File Size must be Equal or less than 1mb";
                            }
                        }
                        else
                        {
                            ViewBag.msg = "Inavlid File Type";
                        }
                    }

                    //}
                    else
                    {
                        kid.imgPath = Session["imgPath"].ToString();
                        //if (l != null)
                        //{
                        //    Session["name"] = sa.ad_name;
                        //    l.UserId = userid;
                        //    l.Name = sa.ad_name;
                        //    l.Password = sa.password;
                        //    l.Email = sa.ad_email;
                        //    l.RoleID = 1;
                        //    db.Entry(l).State = EntityState.Modified;
                        //    db.SaveChanges();
                        //}
                        //superadmin.ad_name = sa.ad_name;

                        //superadmin.ad_email = sa.ad_email;
                        //superadmin.ad_password = sa.password;
                        //superadmin.ad_Id = userid;
                        kid.StoryTitle = sa.StoryTitle;
                        kid.shortDes = sa.shortDes;
                        kid.longDes = sa.longDes;
                        kid.statusId = 2;
                        kid.StoryTypeId = sa.StoryTypeId;
                        kid.RoleId = Convert.ToInt32(Session["RoleId"]);
                        kid.UserId = Convert.ToInt32(Session["Ad"]);

                        db.Entry(kid).State = EntityState.Modified;

                        if (db.SaveChanges() > 0)
                        {


                            ViewBag.Message = "Data Updated";
                            return RedirectToAction("viewKidStory");

                        }

                    }
                }

            }
            catch (Exception ex)
            {
                ViewBag.Message = "Not Updated";
                return View();
            }
            return View();
        }


        [HttpPost]
        public JsonResult DeleteKidStory(int storyid)
        {

            bool resul = false;
            KidsStory sc = db.KidsStories.SingleOrDefault(x => x.StoryId == storyid);
            if (sc != null)
            {
                db.KidsStories.Remove(sc);
                db.SaveChanges();
                resul = true;
            }

            return Json(resul, JsonRequestBehavior.AllowGet);
        }






    }
}