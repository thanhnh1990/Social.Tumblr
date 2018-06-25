using DontPanic.TumblrSharp;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace tumblr
{
    class Query
    {
        public IEnumerable<Data> Get_Image()
        {
            mmoDataContext context = new mmoDataContext();
            var query = (from pin in context.Pinterests
                         where !(from post in context.Postings where post.SourceId == 6 select post.ImgId).Contains(pin.Id)
                         && pin.Type == 2 && pin.Image_Url != null
                         select pin)
                         .Take(950);
            List<Data> datas = new List<Data>();
            foreach (var i in query)
            {
                
                Data da = new Data();
                var img = da.CovertImgUrl(i.Image_Url);
                if (img == null)
                {
                    Remove_Pin(i.Id);
                }
                else {
                    var photos = new BinaryFile[] { new BinaryFile(img, i.Note, null) };
                    da.id = i.Id;
                    da.photos = photos;
                    da.title = String.Join("", i.Note.Split('\''));
                    da.tags = da.ConvertTags(i.Note); 
                    datas.Add(da);
                }
            }
            return datas;
        }

        public void Remove_Pin(int id)
        {
            try
            {
                mmoDataContext db = new mmoDataContext();
                Pinterest prod = (from p in db.Pinterests
                                            where p.Id == id
                                            select p).SingleOrDefault();
                db.Pinterests.DeleteOnSubmit(prod);
                db.SubmitChanges();
            }
            catch (Exception ex) { }
        }
        public bool Insert_Posted(int id)
        {
            bool result = false;
            try
            {
                mmoDataContext db = new mmoDataContext();
                Posting post = new Posting
                {
                    ImgId = id,
                    SourceId = 6
                };
                db.Postings.InsertOnSubmit(post);
                db.SubmitChanges();
                result = true;
            }
            catch (Exception ex) { }
            return result;
        }
    }
}
