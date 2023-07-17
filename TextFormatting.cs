using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace StudentsBook
{
    internal class TextFormatting
    {
        /// <summary>
        /// Добавление форматированного текста в текстовый блок с английским текстом
        /// </summary>
        public static void EnglishTextFormatting(TextBlock textBlock)
        {
            textBlock.Text = string.Empty;
            textBlock.Inlines.Add("        Hello! Welcome to electronical English language learning course.\n");
            textBlock.Inlines.Add("        This learning material helps students to develop their abilities to learn English language. ");
            textBlock.Inlines.Add("The information-driven approach in learning inspires students to think about the world around them and building their creativity, participation and performance. ");
            textBlock.Inlines.Add("After all, it just can be fun!");

            textBlock.Inlines.Add("\n        The material presented in this course, corresponds to the English learning level between basic and intermediate. In other words, it corresponds to Intermediate level(B1).Usually, 9th grade or higher students have already mastered this level of language.");
        }

        /// <summary>
        /// Добавление форматированного текста в текстовый блок с русским текстом
        /// </summary>
        public static void RussianTextFormatting(TextBlock textBlock)
        {
            textBlock.Text = string.Empty;
            textBlock.Inlines.Add("        Привет! Добро пожаловать на электронный курс по обучению английскому языку.\n");
            textBlock.Inlines.Add("        Данный учебный материал помогает ученикам развиваться в способности к обучению английскому языку. ");
            textBlock.Inlines.Add("Информативный подход к обучению вдохновляет учеников задуматься об окружающем мире и помогает развивать креативность, заинтересованность и прилежность. ");
            textBlock.Inlines.Add("В конце концов, такой процесс обучения может просто быть весёлым!");

            textBlock.Inlines.Add("\n        Материал, изложенный в данном курсе соответствует уровню перехода с базового уровня знания английского, к продвинутому. Иными словами, уровень Intermediate (B1). Как правило, ученики девятых классов и старше уже владеют таким уровнем знания английского языка. ");

            textBlock.Inlines.Add("\nВ разделе \"Reading\" представлен текст на английском языке, прочитав который, необходимо выполнить задание, связанное с текстом\n");
            textBlock.Inlines.Add("В разделе \"Dictionary\" содержится словарь со словами из заданий.\n");
            textBlock.Inlines.Add("В разделе \"Testing\" можно пройти контрольное тестирование на общие знания английского языка для текущего курса.");
        }
    }
}
