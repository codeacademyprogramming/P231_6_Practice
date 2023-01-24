using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsName("Hikmet"));

            string[] fullnames = { "Hikmet    Abbas", "Tofiq Qulamov", "Nermin Abbasova", "Hakim Abdullayev" };
            var names = MakeNames(fullnames);
            //{"Hikmet", "Tofiq","Nermin","Hakim"}

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            string[] arr = { "alma", "armud", "Hikmet", "alma", "Abbas","Hikmet" };

            var newArr = MakeUniqueArr(arr);

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
            //{"alma","armud","Hikmet","Abbas"}

            //Verilmis yazini bas herfi boyuk digerleri kicik halda qaytaran metod
            string name = "HIKmeT";
            Capitalize(ref name);//Hikmet
            Console.WriteLine(name);

            string nameInput;
            do
            {
                Console.WriteLine("Adinizi daxil edin:");
                nameInput = Console.ReadLine();

            } while (IsName(nameInput)==false);


            //cosole-da email deyeri istenilsin. Eger deyerde @ xarakteri yoxdursa yeniden istenilsin
            string email;
            do
            {
                Console.WriteLine("Emailinizi daxil edin:");
                email = Console.ReadLine();

            } while (!email.Contains('@'));

            Console.WriteLine(GetDomain(email));

        }

        static string GetDomain(string email)
        {
            //hiko@gmail.com
            var atIndex = email.IndexOf('@');
            var domain = email.Substring(email.IndexOf('@') + 1);

            return domain;
        }

        static void Capitalize(ref string str)
        {
            str = char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }

        static string[] MakeUniqueArr(string[] arr)
        {
            string[] newArr = new string[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(newArr, arr[i]) == -1)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = arr[i];
                }
            }

            return newArr;
        }

        static string[] MakeNames(string[] arr)
        {
            string[] names = new string[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                var fullname = arr[i].TrimStart();
                var name = arr[i].TrimStart().Substring(0, fullname.IndexOf(' '));
                names[i] = name;
            }

            return names;
        }


        static bool IsName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            if (!char.IsUpper(name[0]))
                return false;

            for(var i=1;i<name.Length; i++)
            {
                if (!char.IsLower(name[i]))
                    return false;
            }
            return true;
        }



    }
}
