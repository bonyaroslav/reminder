using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fligern.UsefulReminder.Base
{
    public enum LoadType
    {
        DefaultBuiltIn = 0,
        FilDefaulte = 1,
        FileCustom = 2,
        WebserviceDefault = 3,
        WebserviceCustom = 4,
        Other = 5

    }

    public class DataManager : IDisposable
    {
        private Random random = new Random();
        private List<string> data = new List<string> { 
        "Сон - странная вещь: мало спишь - хочется спать, потому что не высыпаешься; много спишь - хочется спать, потому что привык много спать.",
        "Не то, чтобы не рад Вас видеть, просто не успеваю соскучиться.",
        "Если хочешь, чтобы у тебя было мало времени, ничего не делай.",
        "Женщины угадывают всё, а если ошибаются, значит, нарочно. Жан-Альфонс Карр"
        };

        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public int Amount
        {
            get
            {
                if (data != null)
                {
                    return data.Count();
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Gets the data random.
        /// </summary>
        /// <returns></returns>
        public ReturnData GetDataRandom()
        {
            ReturnData result= new ReturnData();
            if (Amount > 0)
            {
                var number = random.Next(0, Amount);
                result.Number = number;
                result.Data = data[number];
            }
            return result;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public ReturnData GetData(int number)
        {
            ReturnData result = new ReturnData();
            if (Amount > 0 && number >= 0 && number < Amount)
            {
                result.Number = number;
                result.Data = data[number];
            }

            return result;
        }

        public void Load(LoadType type = LoadType.DefaultBuiltIn)
        {

        }



        public void Dispose()
        {

        }
    }    
}
