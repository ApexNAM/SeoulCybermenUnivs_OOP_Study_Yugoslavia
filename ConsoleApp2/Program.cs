using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Yugoslavia
    {
        public string main_capital;
        public float supPower;

        public Yugoslavia(string startCap, float startPower)
        {
            main_capital = startCap;
            supPower = startPower;
        }

        public void CitySuppression(string city)
        {
            Console.Write(city + "를 진압하시겠습니까?");
            string yn = Console.ReadLine();

            Random random = new Random();

            float cityPower = random.Next(5, 10);

            if(yn == "Yes")
            {
                if(supPower > cityPower)
                {
                    Console.WriteLine("진압에 성공했습니다!");
                }
                else
                {
                    Console.WriteLine("진압에 실패했습니다..");
                }
            }
            else if(yn == "No")
            {
                Console.WriteLine("진압을 거부했습니다.");
            }
        }

        public void ChangeCapital()
        {
            Console.Write("수도를 변경하시겠습니까?");
            string yn = Console.ReadLine();

            if (yn == "Yes")
            {
                Console.Write(main_capital + "의 수도 이름을 변경해주세요.");
                string swtichCapital = Console.ReadLine();

                Console.WriteLine("수도이름이 " + swtichCapital +"로 변경되었습니다..");
                main_capital = swtichCapital;
            }
            else if(yn == "No")
            {
                Console.WriteLine("수도를 유지합니다..");
            }
        }
        public void AddPower(float power)
        {
            Console.WriteLine("진압할 힘을 증가했습니다!");
            supPower += power;
        }

        public void DownPower(float power)
        {
            Console.WriteLine("진압할 힘을 축소했습니다!");
            supPower -= power;

            if (supPower == 0f)
            {
                Console.WriteLine("군대가 붕괴되었습니다!!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Yugoslavia serbia = new Yugoslavia("베오그라드",5f);

            int code;

            while ((code = menuSelect()) != 6)
            {

                switch (code)
                {
                    case 1:
                        serbia.AddPower(5);
                        break;
                    case 2:
                        serbia.DownPower(5);
                        break;
                    case 3:
                        serbia.ChangeCapital();
                        break;
                    case 4:
                        serbia.CitySuppression("남부시");
                        break;
                    case 5:
                        Console.WriteLine("이 나라의 상태는.. 수도 : " + serbia.main_capital + "이고 진압할 능력의 힘은 " + serbia.supPower + "입니다..");
                        break;
                }
            }
        }

        static int menuSelect()
        {
            int select;

            Console.WriteLine("1. 진압군 증가");
            Console.WriteLine("2. 진압군 축소");
            Console.WriteLine("3. 수도명 변경");
            Console.WriteLine("4. 도시 반란 진압");
            Console.WriteLine("5. 나라 상태..?");
            Console.Write("번호로 명령해주십시오.");

            select = int.Parse(Console.ReadLine());
            return select;
        }
    }
}
