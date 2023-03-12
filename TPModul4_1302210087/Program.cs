// See https://aka.ms/new-console-template for more information
using System;
class KodePos
{
    public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja};
    public static int getKodePos(Kelurahan kelu)
    {
        int[] kode_Pos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kode_Pos[(int)kelu];
    }
}

class DoorMachine
{
    public enum StatKey {Terkunci, Terbuka}
}


public class main
{
    static void Main(String[] args)
    {
        KodePos.Kelurahan kelu = KodePos.Kelurahan.Mengger;
        int kode_pos = KodePos.getKodePos(kelu);
        Console.WriteLine("Kode Pos "+ kelu +": "+kode_pos+ "\n");

        String something = Console.ReadLine();
        DoorMachine.StatKey declare = DoorMachine.StatKey.Terkunci;
        if ((declare == DoorMachine.StatKey.Terkunci || declare == DoorMachine.StatKey.Terbuka) && something != null && something == "Buka Pintu")
        {
            Console.WriteLine("Pintu Tidak Terkunci");
            declare = DoorMachine.StatKey.Terbuka;
        }
        else if ((declare == DoorMachine.StatKey.Terkunci || declare == DoorMachine.StatKey.Terbuka) && something != null && something == "Kunci Pintu")
        {
            Console.WriteLine("Pintu Terkunci");
            declare = DoorMachine.StatKey.Terkunci;
        }

    }
}
