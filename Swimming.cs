using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCWFA
{
    public class Swimming : Sport, IShow
    {
        private double CaloriesBurned;
        public double caloriesBurned { get => CaloriesBurned; set => CaloriesBurned = value; }
        public Swimming(string when, int time) : base(when, time)
        {
            this.when = when;
            this.time = time;
        }

        public override double CalculateCaloriesBurned(double BMI, double time, double velocity = 1)
        {
            double CaloriesBurned = 0;
            CaloriesBurned = (365 + ((BMI) / 10.2) * 113) * (time / 60);
            return CaloriesBurned;
        }

        public string ShowActivity(string name, double velo = 0)
        {
            string TextShowActivity = "";
            TextShowActivity = name + ", Anda telah melakukan renang selama " + time.ToString()
                + " menit pada " + when + " hari." + "\n";
            return TextShowActivity;
        }

        public string ShowRecommendation(double CaloriesBurned)
        {
            string TextShowRecommendation = "";
            if (CaloriesBurned < 150)
            {
                TextShowRecommendation = "Anda hanya membakar " + CaloriesBurned.ToString() + " kalori setelah berenang." + "\n"
                    + "Kami menyarankan anda untuk menambah waktu Anda dalam berenang agar dapat membakar kalori lebih banyak." + "\n"
                    + "Jangan lupa untuk melakukan aktivitas berenang ini secara rutin yaa:). Have a nice day!" + "\n";
            }
            else if (CaloriesBurned >= 150 && CaloriesBurned < 900)
            {
                TextShowRecommendation = "Anda telah membakar " + CaloriesBurned.ToString() + " kalori setelah berenang." + "\n"
                    + "Anda telah melakukan pembakaran kalori yang cukup! Kerja bagus! :)" + "\n"
                    + "Jangan lupa untuk melakukan aktivitas berenang ini secara rutin yaa :). Have a nice day!" + "\n";
            }
            else
            {
                TextShowRecommendation = "Anda telah membakar " + CaloriesBurned.ToString() + " kalori setelah berenang." + "\n"
                    + "Anda telah melakukan pembakaran kalori yang sangat besar! Pasti melelahkan, kami menyarankan untuk beristirahat ya friend:) Kerja bagus!" + "\n"
                    + "Jangan lupa untuk melakukan aktivitas berenang ini secara rutin yaa :). Have a nice day!" + "\n";
            }
            return TextShowRecommendation;
        }
    }
}
