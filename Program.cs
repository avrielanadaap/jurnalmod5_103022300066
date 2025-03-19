using mod5_103022300066;
using modul5_103022300066;
public class program
{
    public static void Main(string[] args)
    {
        pemrosesData pemroses = new pemrosesData();
        pemroses.DapatkanNilaiTerbesar<int>(30, 00, 66);

        simpleDatabase<int> data = new simpleDatabase<int>();
        data.addData(30);
        data.addData(00);
        data.addData(66);
        data.printaAllData();
    }
}
