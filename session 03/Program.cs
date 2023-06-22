
public class BaseOffice
{
  public virtual int CalculateProfit(int value1, int value2)
  {
    int profit = 0;
    /*
     * فرمول کلی  سود
     */
    return profit;
  }

}






public class SubOffice1 : BaseOffice
{
  public void RegisterProduct()
  {

  }

  public void PrintReport()
  {
    int profitValue = CalculateProfit(1000, 2000);
    /*
محاسبه میکنیم و میفرستیم به چاپگر     *
     */
  }

}





public class SubOffice2 : BaseOffice
{

  public void SubmitPayment()
  {
    //
  }

  public override int CalculateProfit(int value1, int value2)
  {
    return base.CalculateProfit(value1, value2);
  }
}






public class SubOffice3 : BaseOffice
{

  public void TestProducts()
  {
    //
  }

  public override int CalculateProfit(int value1, int value2)
  {
    // return base.CalculateProfit(value1, value2);

    int profitvalue = 0;

    /*
     *نوشتن فرمولی کاملا متفاوت برای محاسبه سود
     */

    return profitvalue;
  }
}







public class SubOffice4 : BaseOffice
{

  public void MangeProducts()
  {
    //
  }

  public override int CalculateProfit(int value1, int value2)
  {
    int calcutatPart1 = 0;
    int calcutatPart2 = 0;
    int calcutatPart3 = 0;

    int finalProfit = 0;

    calcutatPart1 = base.CalculateProfit(value1, value2);

    /*
     * calcutatPart2=value1+value2/calcutatPart1;
     */

    /*
    * calcutatPart3=100*(value1+value2)/calcutatPart2;
    */

    finalProfit = calcutatPart1 + calcutatPart2 + calcutatPart3;

    return finalProfit;
  }
}