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
            //�kiye b�l�nen say�lar�n bulunup listelenmesi
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 0)
                {
                    ikiye += i + ",";
                }
            }
            print("�kiye tam b�l�nen say�lar: " + ikiye);

            //��e b�l�nen say�lar�n bulunup listelenmesi

            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 3 == 0)
                {
                    uce += i + ",";
                }
            }
            print("��e tam b�l�nen say�lar: " + uce);


            //D�rde b�l�nen say�lar�n bulunup listelenmesi

            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 4 == 0)
                {
                    dorde += i + ",";
                }
            }
            print("D�rde tam b�l�nen say�lar: " + dorde);

            //Be�e b�l�nen say�lar�n bulunup listelenmesi

            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 5 == 0)
                {
                    bese += i + ",";
                }
            }
            print("Be�e tam b�l�nen say�lar: " + bese);
        }
        else if (sayi2 < sayi1)
        {
            //�kiye b�l�nen say�lar�n bulunup listelenmesi

            for (int i = sayi2; i <= sayi1; i++)
            {
                if (i % 2 == 0)
                {
                    ikiye += i + ",";
                }
            }
            print("�kiye tam b�l�nen say�lar: " + ikiye);

            //��e b�l�nen say�lar�n bulunup listelenmesi

            for (int i = sayi2; i <= sayi1; i++)
            {
                if (i % 3 == 0)
                {
                    uce += i + ",";
                }
            }
            print("��e tam b�l�nen say�lar: " + uce);


            //D�rde b�l�nen say�lar�n bulunup listelenmesi

            for (int i = sayi2; i <= sayi1; i++)
            {
                if (i % 4 == 0)
                {
                    dorde += i + ",";
                }
            }
            print("D�rde tam b�l�nen say�lar: " + dorde);



            //Be�e b�l�nen say�lar�n bulunup listelenmesi
            {
                for (int i = sayi2; i <= sayi1; i++)
                {
                    if (i % 5 == 0)
                    {
                        bese += i + ",";
                    }
                }
                print("Be�e tam b�l�nen say�lar: " + bese);
            }
        }
        
        else
        {
            print("girdi�iniz say�lar e�it");
        }
    }


    void Start()
    {
        TumIslemler(10, 10);
    }

}
