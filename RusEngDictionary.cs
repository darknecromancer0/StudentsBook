using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsBook
{
    public class RusEngDictionary
    {
        public String English { get; set; }
        public String Russian { get; set; }
        public String Transcription { get; set; }

        public RusEngDictionary(String englishWord, String russianWord, String transcription)
        {
            this.English = englishWord;
            this.Russian = russianWord;
            this.Transcription = transcription;

        }

        public static List<RusEngDictionary> GetDictionaryList()
        {
            return new List<RusEngDictionary>(new RusEngDictionary[14] {
            new RusEngDictionary("fee", "плата, платёж", "fiː"),
            new RusEngDictionary("free-time activity", "занятия в свободное время", "friː-taɪm ækˈtɪvɪti"),
            new RusEngDictionary("dormitory", "общежитие", "ˈdɔː.mɪ.tər.i"),
            new RusEngDictionary("committee", "комитет", "kəˈmɪt.i"),
            new RusEngDictionary("diverse", "разнообразный", "daɪˈvɜːs"),

            new RusEngDictionary("compulsory", "обязательный", "kəmˈpʌl.sər.i"),
            new RusEngDictionary("take part", "принимать участие", "teɪk pɑːt"),
            new RusEngDictionary("take up", "занимать, принимать", "teɪk ʌp"),
            new RusEngDictionary("take care of", "заботиться о", "teɪk keər əv"),
            new RusEngDictionary("take place", "замещать, занимать место", "teɪk pleɪs"),

            new RusEngDictionary("voluntary", "добровольный", "ˈvɒləntəri"),
            new RusEngDictionary("to rescue", "спасать", "tə ˈreskjuː"),
            new RusEngDictionary("disabled", "инвалид", "dɪˈseɪbld"),
            new RusEngDictionary("restriction", "запрет", "rɪˈstrɪkʃən"),



        });
        }
    }
}
