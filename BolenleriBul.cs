using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolenleriBul : MonoBehaviour
{
    string ikiye = "";
    string uce = "";
    string dorde = "";
    string bese = "";

    void TumIslemler(int sayi1, int sayi2)
    {

        if (sayi1 < sayi2)
        {
            //Ýkiye bölünen sayýlarýn bulunup listelenmesi
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 0)
                {
                    ikiye += i + ",";
                }
            }
            print("Ýkiye tam bölünen sayýlar: " + ikiye);

            //Üçe bölünen sayýlarýn bulunup listelenmesi

            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 3 == 0)
                {
                    uce += i + ",";
                }
            }
            print("Üçe tam bölünen sayýlar: " + uce);


            //Dörde bölünen sayýlarýn bulunup listelenmesi

            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 4 == 0)
                {
                    dorde += i + ",";
                }
            }
            print("Dörde tam bölünen sayýlar: " + dorde);

            //Beþe bölünen sayýlarýn bulunup listelenmesi

            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 5 == 0)
                {
                    bese += i + ",";
                }
            }
            print("Beþe tam bölünen sayýlar: " + bese);
        }
        else if (sayi2 < sayi1)
        {
            //Ýkiye bölünen sayýlarýn bulunup listelenmesi

            for (int i = sayi2; i <= sayi1; i++)
            {
                if (i % 2 == 0)
                {
                    ikiye += i + ",";
                }
            }
            print("Ýkiye tam bölünen sayýlar: " + ikiye);

            //Üçe bölünen sayýlarýn bulunup listelenmesi

            for (int i = sayi2; i <= sayi1; i++)
            {
                if (i % 3 == 0)
                {
                    uce += i + ",";
                }
            }
            print("Üçe tam bölünen sayýlar: " + uce);


            //Dörde bölünen sayýlarýn bulunup listelenmesi

            for (int i = sayi2; i <= sayi1; i++)
            {
                if (i % 4 == 0)
                {
                    dorde += i + ",";
                }
            }
            print("Dörde tam bölünen sayýlar: " + dorde);



            //Beþe bölünen sayýlarýn bulunup listelenmesi
            {
                for (int i = sayi2; i <= sayi1; i++)
                {
                    if (i % 5 == 0)
                    {
                        bese += i + ",";
                    }
                }
                print("Beþe tam bölünen sayýlar: " + bese);
            }
        }
        
        else
        {
            print("girdiðiniz sayýlar eþit");
        }
    }


    void Start()
    {
        TumIslemler(10, 10);
    }

}
