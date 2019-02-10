using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
namespace rouigram
{
    public class rouigam
    {
        string api = "http://api.pythony.ir/v1/?username=";
        /// <summary>
        /// to get user_id 
        /// </summary>
        /// <param name="usrname">username of instagram account that u want to get her/his user_id</param>
        /// <returns></returns>
        public string user_id(string usrname)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                    "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    string url2 = api + usrname;
                    string result = wc.DownloadString(url2);

                    dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                    string user_id = end.rouigram.user_id;
                    return user_id;

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// to get username
        /// </summary>
        /// <param name="usrname">username of instagram account that u want to get her/his username</param>
        /// <returns></returns>
        public string username(string usrname)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                    "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    string url2 = api + usrname;
                    string result = wc.DownloadString(url2);

                    dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                    string username = end.rouigram.username;
                    return username;

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// to get full name
        /// </summary>
        /// <param name="usrname">username of instagram account that u want to get her/his full name</param>
        /// <returns></returns>
        public string fullname(string usrname)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                    "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    string url2 = api + usrname;
                    string result = wc.DownloadString(url2);

                    dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                    string fullname = end.rouigram.fullname;
                    return fullname;

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// to get picture of profile
        /// </summary>
        /// <param name="usrname">username of instagram account that u want to get her/his profile picture</param>
        /// <returns></returns>

        public string profile_hd_photo(string usrname)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                    "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    string url2 = api + usrname;
                    string result = wc.DownloadString(url2);

                    dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                    string profile_hd_photo = end.rouigram.profile_hd_photo;
                    return profile_hd_photo;

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// to get the follower count
        /// </summary>
        /// <param name="usrname">username of instagram account that u want to get her/his follower_count</param>
        /// <returns></returns>
        public string follower_count(string usrname)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                    "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    string url2 = api + usrname;
                    string result = wc.DownloadString(url2);

                    dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                    string follower_count = end.rouigram.follower_count;
                    return follower_count;

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// to get following count
        /// </summary>
        /// <param name="usrname">username of instagram account that u want to get her/his following _count</param>
        /// <returns></returns>
        public string following_count(string usrname)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                    "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    string url2 = api + usrname;
                    string result = wc.DownloadString(url2);

                    dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                    string following_count = end.rouigram.following_count;
                    return following_count;

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }


        /// <summary>
        /// to get the biography
        /// </summary>
        /// <param name="usrname">username of instagram account that u want to get her/his biography</param>
        /// <returns></returns>
        public string biography(string usrname)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                    "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    string url2 = api + usrname;
                    string result = wc.DownloadString(url2);

                    dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                    string biography = end.rouigram.biography;
                    return biography;

                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        /// <summary>
        /// to get the external_url
        /// </summary>
        /// <param name="usrname">username of instagram account that u want to get her/his external_url</param>
        /// <returns></returns>
        public string external_url(string usrname)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                    "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    string url2 = api + usrname;
                    string result = wc.DownloadString(url2);

                    dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                    string external_url = end.rouigram.external_url;
                    return external_url;

                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        /// <summary>
        /// to get the is_private status
        /// </summary>
        /// <param name="usrname">username of instagram account that u want to get her/his is_private status</param>
        /// <returns></returns>
        public string is_private(string usrname)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                    "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    string url2 = api + usrname;
                    string result = wc.DownloadString(url2);

                    dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                    string is_private = end.rouigram.is_private;
                    return is_private;

                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        /// <summary>
        /// to get media_count
        /// </summary>
        /// <param name="usrname">username of instagram account that u want to get her/his media_count</param>
        /// <returns></returns>
        public string media_count(string usrname)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                    "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    string url2 = api + usrname;
                    string result = wc.DownloadString(url2);

                    dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                    string media_count = end.rouigram.media_count;
                    return media_count;

                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }



        }
    }



}
