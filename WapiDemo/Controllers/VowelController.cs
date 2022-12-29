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
        public ActionResult<Histogram> PostVowel(Vowel vowel)
        {
            Histogram hst = new Histogram();
            hst.Hstgrm = new();
            //Histogram dict.e eklenmesi
            foreach (var s in sesliHarfler)
            {
                hst.Hstgrm.Add(s, 0);
                
            }
            foreach (var v in vowel.Text)
            {
                if (sesliHarfler.Contains(v))
                {
                    hst.Hstgrm[v]++;
                
                
                }

            }
            hst.Text = vowel.Text;

            return Ok(hst);                
        }


    }
}
