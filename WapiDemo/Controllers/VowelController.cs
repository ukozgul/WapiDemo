using Microsoft.AspNetCore.Mvc;
using WapiDemo.Models;

namespace WapiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VowelController : ControllerBase
    {
        private static List<char> sesliHarfler = new List<char>
        {'a','e','ı','i','u','ü','o','ö','A','E','I', 'İ', 'O', 'Ö', 'U', 'Ü' };

        [HttpPost]
        [Route("Vowel")]
        //public ResponseV MetinHistogram(RequestV req)
        public ActionResult<ResponseV> MetinHistogram(RequestV req) //Else yazıp BadRequest denildiği için ActionResult kullanıldı.
        {


            //Dönüş Modeli
            var result = new ResponseV();

            //Dic initialize (NullExeptionError almamak için)
            //result.HistogramData = new Dictionary<char, int>(); => Modelde (ResponseV) initialize edildi....
            
            if (req.Language=="tr")
            {

                //Sesli harfler listesinin Dict.e eklenmesi
                foreach (var s in sesliHarfler)
                {
                    result.HistogramData.Add(s, 0);
                }

                foreach (var v in req.Text)
                {
                    if (sesliHarfler.Contains(v))
                    {
                        result.HistogramData[v]++;
                    }
                }
                result.Text = req.Text;

            }
            else
            {
                return BadRequest();
            }

                return Ok(result);

        }


    }
}
