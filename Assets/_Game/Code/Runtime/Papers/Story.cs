using System;
using System.Collections.Generic;
using UnityEngine;

namespace ForestOfMysteries.Papers
{
    public class Story : MonoBehaviour
    {
        private const int _number = 10;
        
        private const string text0 = "В чёрном небе наблюдая " +
                                       "\nБелых точек череду, " +
                                       "\nЯ заметил вдруг у края Золотистую звезду " +
                                       "\nИ с тех пор живу без сна я -" +
                                       "\nВсё её прихода жду."; 
        
        private const string text1 = "Мчался по волнам эфира" +
                                     "\nЛуч звезды - и прям, и горд," +
                                     "\nПо всему пространству мира" +
                                     "\nРай блаженства был простёрт," +
                                     "\nРазносила звонко лира" +
                                     "\nПо Вселенной свой аккорд."; 
        
        private const string text2 = "И казалось мне, что где-то" +
                                     "\nЖизнь свободна и легка," +
                                     "\nБесконечно длится лето," +
                                     "\nСловно сон плывут века," +
                                     "\nЛьётся музыка рассвета" +
                                     "\nОт волшебного смычка."; 
        
        private const string text3 = "Там, я мнил - любви жилище," +
                                     "\nПыл вражды давно угас;" +
                                     "\nТам не думают о пище" +
                                     "\nИ улыбки - без гримас;" +
                                     "\nУ людей там мысли чище" +
                                     "\nИ добрее, чем у нас."; 
        
        private const string text4 = "Так я думал - и мозги мне" +
                                     "\nЗастилал багровый бред," +
                                     "\nБудто в серой дымке зимней" +
                                     "\nТихо таял солнца свет;" +
                                     "\nИ я слышал в прежнем гимне" +
                                     "\nЧуждый тон грядущих бед."; 
        
        private const string text5 = "Цвет звезды из золотого" +
                                     "\nСтановился всё красней;" +
                                     "\nНа устах застыло слово -"; 
        
        private const string text6 = " Понял я, что стало с ней;" +
                                      "\nИ в безумьи начал снова" +
                                      "\nЯзыком дразниться Змей."; 
        
        private const string text7 = "Так меня поймала в клещи" +
                                     "\nЗолотистая звезда:" +
                                     "\nМне заманчивые вещи";

        private const string text8 = "Показала без стыда" +
                                     "\nИ мне в душу страх зловещий";
        
        private const string text9 = "Поселила навсегда !";

        protected readonly List<string> _story = new List<string>();

        private void Awake()
        {
            _story.Add(text0);
            _story.Add(text1);
            _story.Add(text2);
            _story.Add(text3);
            _story.Add(text4);
            _story.Add(text5);
            _story.Add(text6);
            _story.Add(text7);
            _story.Add(text8);
            _story.Add(text9);
        }
    }
}