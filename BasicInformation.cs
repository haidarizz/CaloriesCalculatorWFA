using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCWFA
{
    public class BasicInformation
    {
        private string name;
        private int weight;
        private int height;
        private int age;
        private int sex;
        private double BMI;
        private double BMR;
        private double CaloriesNeeded;
        private int frequency;
        public double bmi { get => BMI; set => BMI = value; }
        public double bmr { get => BMR; set => BMR = value; }
        public double caloriesNeeded { get => CaloriesNeeded; set => CaloriesNeeded = value; }
        public int freq { get => frequency; set => frequency = value; }
        public string Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Height { get => height; set => height = value; }
        public int Age { get => age; set => age = value; }
        public int Sex { get => sex; set => sex = value; }

        public BasicInformation(string name, int weight, int height, int age, int sex)
        {
            this.Name = name;
            this.Weight = weight;
            this.Height = height;
            this.Age = age;
            this.Sex = sex;
        }

        public string Greeting(string name)
        {
            string Text = "";
            Text = "Haloo " + name + "! " + "Senang bertemu dengan Anda!" + "\n" + "Ini adalah data diri Anda";
            return Text;
        }

        public double CalculateBMI(int weight, int height)
        {
            double BMI = 0;
            double height2;
            double height3;
            height2 = height / 10;
            height3 = height2 / 10;
            BMI = weight / (height3 * height3);
            return BMI;
        }

        public double CalculateBMR(int weight, int height, int age, int sex)
        {
            double BMR = 0;
            if (sex == 1)
            {
                BMR = 66.5 + (13.7 * weight) + (5 * height) - (6.8 * age);
            }
            else if (sex == 2)
            {
                BMR = 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
            }
            return BMR;
        }

        public double CalculateCaloriesNeeded(double BMR, int frequency)
        {
            double multiplier = (frequency / 10) * 0.7 + 1.2;
            double CaloriesNeeded = multiplier * BMR;
            return CaloriesNeeded;
        }

        public string ShowBMI(double BMI)
        {
            string TextShowBMI = "";
            if (BMI < 18.5)
            {
                TextShowBMI = "BMI (Body Mass Index) Anda adalah " + BMI.ToString() + "." + "\n"
                    + "Berat badan Anda berada di dalam kategori di bawah normal." + "\n"
                    + "Anda disarankan untuk memperbaiki pola makan dan menambah berat badan" + "\n" 
                    + "melalui program-program yang bisa menambah berat badan." + "\n"
                    + "Meskipun Anda termasuk dalam kategori kurang berat badan," + "\n" 
                    + "Anda tetap disarankan berolahraga untuk menjaga kebugaran." + "\n";
            }
            else if (BMI >= 18.5 && BMI < 24.9)
            {
                TextShowBMI = "BMI (Body Mass Index) Anda adalah " + BMI.ToString() + "." + "\n"
                    + "Berat badan Anda berada di dalam kategori normal." + "\n"
                    + "Kerja bagus! Anda disarankan untuk menjaga pola makan, berolahraga," + "\n" 
                    + "dan beraktivitas agar tetap memiliki badan yang ideal." + "\n";
            }
            else if (BMI >= 24.9 && BMI < 29.9)
            {
                TextShowBMI = "BMI (Body Mass Index) Anda adalah " + BMI.ToString() + "." + "\n"
                    + "Berat badan Anda berada di dalam kategori kelebihan berat badan." + "\n"
                    + "Anda disarankan untuk memperbaiki pola makan dan melakukan diet sehat agar terhindar" + "\n" 
                    + "dari penyakit-penyakit akibat kelebihan berat badan seperti kanker, diabetes, dan lain-lain." + "\n"
                    + "Selain itu, Anda juga disarankan untuk rutin berolahraga" + "\n" 
                    + "agar dapat membakar kalori dengan baik." + "\n";
            }
            else
            {
                TextShowBMI = "BMI (Body Mass Index) Anda adalah " + BMI.ToString() + "." + "\n"
                    + "Berat badan Anda berada di dalam kategori obesitas." + "\n"
                    + "Anda disarankan untuk memperbaiki pola makan dan melakukan diet sehat agar terhindar" + "\n" 
                    + "dari penyakit-penyakit akibat kelebihan berat badan seperti kanker, diabetes, dan lain-lain." + "\n"
                    + "Selain itu, Anda juga disarankan untuk rutin berolahraga" + "\n" 
                    + "agar dapat membakar kalori dengan baik." + "\n"
                    + "Anda harus bekerja keras untuk menurunkan berat badan! Semangattt!!" + "\n";
            }
            return TextShowBMI;
        }

        public string ShowBMR(double BMR, double CaloriesNeeded)
        {
            string TextShowBMR = "";
            TextShowBMR = "BMR (Basal Metabolic Rate) Anda adalah " + BMR.ToString() + "." + "\n"
                + "Kalori yang anda butuhkan setiap harinya adalah " + CaloriesNeeded.ToString() + " kalori." + "\n"
                + "Anda diharapkan memenuhi kebutuhan kalori tersebut agar anda" + "\n" 
                + "tidak kekurangan energi untuk melakukan aktivitas sehari-hari." + "\n"
                + "Kalori dapat diperoleh dari makanan-makanan yang Anda makan," + "\n" 
                + "jangan lupa untuk memakan makanan yang sehat ya!" + "\n"
                + "Have a nice day :))" + "\n";
            return TextShowBMR;
        }
    }
}
