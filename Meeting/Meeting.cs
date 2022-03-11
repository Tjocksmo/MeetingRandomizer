using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Meeting
{
    class Meeting : IMeeting
    {
        public string Secretary { get; set; }
        public string Adjuster { get; set; }
        public override string ToString() => $"Mötets sekreterare: {Secretary}\nMötets justerare: {Adjuster}";
        public Meeting ()
        {
            RandomSecretaryAndAdjuster();
        }
        public void RandomSecretaryAndAdjuster()
        {
            var rnd = new Random();
            bool OK = false;

            while(!OK)
            {
                string[] secretary = "Andreas Brunnström,Amanda Almgren,Anton Thunman Jonsson,Cecilia Nyberg,Daniel Runnvik,Daniel Zone,Edgar Runnman,Emil Magnusson,Fabien Kuhnlinen,Felix Englund,Felix Englund,Jens Andersson, Johan Bengter,Marcus Broman,Martin Berntsson,Mattias Lidbom,Robert von Krusenstjerna,Sanna Edström,Simon Machhabhai".Split(',');
                string[] adjuster = "Andreas Brunnström,Amanda Almgren,Anton Thunman Jonsson,Cecilia Nyberg,Daniel Runnvik,Daniel Zone,Edgar Runnman,Emil Magnusson,Fabien Kuhnlinen,Felix Englund,Felix Englund,Jens Andersson, Johan Bengter,Marcus Broman,Martin Berntsson,Mattias Lidbom,Robert von Krusenstjerna,Sanna Edström,Simon Machhabhai".Split(',');

                this.Secretary = secretary[rnd.Next(0, secretary.Length)];
                this.Adjuster = adjuster[rnd.Next(0, adjuster.Length)];

                if (Secretary != Adjuster)
                {
                    OK = true;
                }
            }
        }
    }
}
