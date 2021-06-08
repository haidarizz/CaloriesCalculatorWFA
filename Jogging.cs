using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCWFA
{
    public class Jogging : Sport, IShow
    {
        private double distance;
        private double velocity;
        private double CaloriesBurned;
        public double velo { get => velocity; set => velocity = value; }
        public double caloriesBurned { get => CaloriesBurned; set => CaloriesBurned = value; }

        public Jogging(string when, int time, double distance) : base(when, time)
        {
            this.when = when;
            this.time = time;
            this.distance = distance;
        }

        public double CalculateVelocity(double distance, double hours)
        {
            double velocity = 0;
            velocity = distance / hours;
            return velocity;
        }

        public override double CalculateCaloriesBurned(double BMI, double distance, double velocity = 8)
        {
            double multiplier = 0;
            if (BMI < 18.5)
            {
                multiplier = 0.95;
            }
            else if (BMI >= 18.5 && BMI < 24.9)
            {
                multiplier = 1;
            }
            else if (BMI >= 24.9 && BMI < 29.9)
            {
                multiplier = 1.2;
            }
            else
            {
                multiplier = 1.4;
            }
            double CaloriesBurned = 0;
            CaloriesBurned = (velocity / 8) * multiplier * distance * 60;
            return CaloriesBurned;
        }

        public string ShowActivity(string name, double velo)
        {
            string TextShowActivity = "";
            TextShowActivity = name + ", Anda telah melakukan jogging selama " + time.ToString() + " menit" + 
                "\n" + "pada " + when + " hari dengan jarak " + distance.ToString() + " kilometer" + "\n" + 
                "dengan kecepatan rata-rata " + velo.ToString() + " km/jam";
            return TextShowActivity;
        }

        public string ShowRecommendation(double CaloriesBurned)
        {
            string TextShowRecommendation = "";
            if (CaloriesBurned < 150)
            {
                TextShowRecommendation = "Anda hanya membakar " + CaloriesBurned.ToString() + " kalori setelah melakukan jogging." + "\n"
                    + "Kami menyarankan anda untuk menambah waktu Anda dalam melakukan jogging agar dapat membakar kalori lebih banyak." + "\n"
                    + "Jangan lupa untuk melakukan aktivitas jogging ini secara rutin yaa:). Have a nice day!" + "\n";
            }
            else if (CaloriesBurned >= 150 && CaloriesBurned < 900)
            {
                TextShowRecommendation = "Anda telah membakar " + CaloriesBurned.ToString() + " kalori setelah melakukan jogging." + "\n"
                    + "Anda telah melakukan pembakaran kalori yang cukup! Kerja bagus! :)" + "\n"
                    + "Jangan lupa untuk melakukan aktivitas jogging ini secara rutin yaa :). Have a nice day!" + "\n";
            }
            else
            {
                TextShowRecommendation = "Anda telah membakar " + CaloriesBurned.ToString() + " kalori setelah melakukan jogging." + "\n"
                    + "Anda telah melakukan pembakaran kalori yang sangat besar! Pasti melelahkan, kami menyarankan untuk beristirahat ya friend:) Kerja bagus!" + "\n"
                    + "Jangan lupa untuk melakukan aktivitas jogging ini secara rutin yaa :). Have a nice day!" + "\n";
            }
            return TextShowRecommendation;
        }
    }
}
