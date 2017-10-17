using System.Collections.Generic;

namespace PingPong.Models
{
  public class PingPonger
  {
    private int _inputNumber;
    private static List<object> _instances = new List<object> {};

    public PingPonger(int inputNumber)
    {
      _inputNumber = inputNumber;
      _instances = PingPonger.CountsTo(inputNumber);
    }

    public int GetInputNumber()
    {
      return _inputNumber;
    }

    public void SetInputNumber(int newInputNumber)
    {
      _inputNumber = newInputNumber;
    }

    public List<object> GetList()
    {
      return _instances;
    }

    public static List<object> CountsTo(int index)
    {
      for (int i = 1; i <= index; i++)
      {
        if (i % 15 == 0)
        {
          _instances.Add("ping-pong");
        } else if (i % 3 == 0)
        {
          _instances.Add("ping");
        } else if (i % 5 == 0)
        {
          _instances.Add("pong");
        } else
        {
          _instances.Add(i);
        }
      }
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
