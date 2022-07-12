﻿/*
    Реализация колеса компетенций c платвормы GeekBrains
    https://gb.ru/
*/
int SumMinOfArray(int[] array, int[] array2)
{
    int n = array.Length;
    int sumN = 0;
    int sum = 0;
    for (int l = 0; l < n; l++)
    {
        if (array[l] < array2[l])
        {
            sumN = array[l];
        }
        else if (array[l] > array2[l])
        {
            sumN = array2[l];
        }
        sum += sumN;
    }
    return sum;
}

int SumOfArray(int[] array)
{
    int sum = 0;
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        sum += array[i];
    }
    return sum;
}

void PrintComp(int[] array)
{
    int[] developer = { 2, 3, 4, 0, 4, 2, 5, 0, 1, 3, 3, 1, 4, 3, 5 };
    int[] tester = { 2, 2, 5, 0, 3, 3, 4, 0, 1, 3, 3, 1, 2, 3, 3 };
    int[] analyst = { 3, 4, 3, 0, 5, 2, 4, 1, 2, 5, 3, 3, 3, 2, 4 };
    int[] projectManager = { 4, 1, 1, 3, 3, 4, 3, 4, 5, 3, 5, 3, 5, 5, 4 };
    int[] productManager = { 3, 2, 3, 3, 3, 4, 2, 4, 4, 3, 5, 2, 4, 4, 3 };

    string[] compITspec = { "Программист", "Тестировщик", "Аналитик", "Проджект-менеджер", "Продакт-менеджер" };

    int point = 0;
    int pointMax = 0;
    int pointProcent = 0;
   
    for (int i = 0; i < 5; i++)
    {
        switch(i)
        {
            case 0: point = SumMinOfArray(array, developer); pointMax = SumOfArray(developer); pointProcent = (point * 100) / pointMax; break;
            case 1: point = SumMinOfArray(array, tester); pointMax = SumOfArray(tester); pointProcent = (point * 100) / pointMax; break;
            case 2: point = SumMinOfArray(array, analyst); pointMax = SumOfArray(analyst); pointProcent = (point * 100) / pointMax; break;
            case 3: point = SumMinOfArray(array, projectManager); pointMax = SumOfArray(projectManager); pointProcent = (point * 100) / pointMax; break;
            case 4: point = SumMinOfArray(array, productManager); pointMax = SumOfArray(productManager); pointProcent = (point * 100) / pointMax; break;
        }

        Console.WriteLine($"{compITspec[i]}: [ {point} / {pointMax} ]. Совпадение: {pointProcent} %");
    }

}

void koleso()
{
    string[] compName = { "Экстраверт", "Интроверт", "Способность к монотонной работе", "Наставничество", "Аналитические навыки", "Эмпатия", "Любопытство", "Ораторское искусство", "Организационные способности", "Критическое мышление", "Многозадачность", "Креативность", "Стрессоустойчивость", "Контроль времени", "Работа с большим объемом информации" };
    string[] compDescription = { " -- человек, который любит общаться с людьми и быть в центре внимания. Получает энергию в социуме.", " -- человек, который сфокусирован на своем внутреннем мире. Получает энергию вне социума.", " -- умение сосредоточиться на выполнении рутинных однообразных задач.", " -- способность и желание передавать свои навыки другим людям.", " -- способность раскладывать информацию «по полочкам» и находить в ней закономерности.", " -- способность понимать чувства других людей и сопереживать им.", " -- способность и желание интересоваться чем-то новым.", " -- умение логично и красиво излагать свои мысли.", " -- умение выcтроить работу других людей для решения определенной задачи. ", " -- способность анализировать информацию, ставить ее под сомнение и давать фактам собственную оценку.", " -- способность эффективно работать, постоянно переключаясь между разными задачами.", " -- способность творчески подходить к задачам и придумывать новые пути для их решения.", " -- способность адаптироваться к стрессам, переносить их без негативных последствий.", " -- способность соблюдать дедлайны и контролировать время выполнения задач.", " -- способность ориентироваться и чувствовать себя комфортно в большом потоке данных." };

    string[] compAnswer = {
    "0 -- Я не люблю быть в центре внимания\n1 -- Я готов общаться с людьми, если это необходимо\n2 -- Я умею общаться и часто делаю это\n3 -- Мне интересно общаться с людьми\n4 -- Мне нравится знакомиться и общаться\n5 -- Я легко иду на контакт с другими людьми",
    "0 -- Мне нужна тишина, чтобы сосредоточиться\n1 -- Я предпочитаю сидеть дома, а не ходить на вечеринки\n2 -- Мне проще написать человеку, чем поговорить лично\n3 -- Я избегаю диалогов, если они не связаны с тем, что мне интересно\n4 -- Мне проще общаться с компьютером, чем с людьми\n5 -- Я не люблю общаться с людьми",
    "0 -- Не могу долго работать над однообразными задачами\n1 -- Я могу делать монотонную работу, но устаю от нее\n2 -- Мне не сложно делать одну и ту же работу постоянно\n3 -- Я делаю рутинные задачи на автомате\n4 -- Мне интересно даже там, где другим работа кажется скучной\n5 -- Я люблю делать хорошо знакомую мне работу",
    "0 -- Мне проще самому сделать, чем объяснять кому-то\n1 -- Если человек готов учиться, то я помогу ему\n2 -- Могу объяснить человеку все что угодно, если это необходимо\n3 -- Я охотно рассказываю о своих знаниях и умениях\n4 -- Мне нравится делиться опытом\n5 -- Люблю учить людей тому, что умею",
    "0 -- Я не люблю копаться в цифрах и отчетах\n1 -- Я готов анализировать информацию, если это необходимо\n2 -- Я умею структурировать и анализировать данные\n3 -- Мне интересно анализировать информацию\n4 -- Мне нравится сравнивать информацию\n5 -- Я люблю находить законамерности в большом массиве данных",
    "0 -- Мне не важно, что чувствуют другие люди\n1 -- Я понимаю чувства других, когда это необходимо\n2 -- Я умею чувствовать других людей\n3 -- Мне интересно узнавать, что чувствуют другие люди\n4 -- Мне нравится ощущать, что чувствуют окружающие меня люди\n5 -- Я люблю понимать, что чувствуют окружающие меня люди",
    "0 -- Я не интересуюсь тем, что выходит за рамки моей профессии\n1 -- Я готов интересоваться новым, если это необходимо\n2 -- Я часто открываю для себя новую информацию\n3 -- Мне интересно искать новую информацию\n4 -- Мне нравится исследовать новое\n5 -- Я люблю изучать информацию, даже не связанную с моей специальностью",
    "0 -- Я не люблю говорить на публику\n1 -- Я готов высказываться, если это необходимо\n2 -- Я умею выступать публичнои и делаю это\n3 -- Мне интересно выступать перед людьми\n4 -- Мне нравится говорить на аудиторию\n5 -- Я могу убедить кого угодно в чем угодно",
    "0 -- Я предпочитаю делать все самостоятельно\n1 -- Я готов организовать других, если это необходимо\n2 -- Я умею организовывать людей\n3 -- Мне интересно выстраивать работу других\n4 -- Мне нравится руководить людьми\n5 -- Я люблю организовывать людей вокруг себя",
    "0 -- Я не люблю перепроверять факты\n1 -- Я готов проверять информацию, если это необходимо\n2 -- Я умею проверять информацию и часто делаю это\n3 -- Мне интересно анализировать информацию\n4 -- Мне нравится самостоятельно оценивать факты\n5 -- Я люблю ставить все под сомнение",
    "0 -- Мне проще сконцентрироваться на одной задаче\n1 -- Я готов делать несколько задач, если это необходимо\n2 -- Я умею переключаться между задачами\n3 -- Мне интересно работать над несколькими проектами\n4 -- Мне нравится работать над несколькими задачами сразу\n5 -- Я люблю переключаться с одной задачи на другую",
    "0 -- Я люблю делать все по готовому шаблону\n1 -- Я готов придумывать новое, если это необходимо\n2 -- Я умею придумывать новые решения и делаю это\n3 -- Мне интересно решать задачи по-своему\n4 -- Мне нравится придумывать нестандартный подход к решению задач\n5 -- Я люблю придумывать что-то новое в своей работе",
    "0 -- Я не могу работать в режиме аврала\n1 -- Я готов к авралам, если это необходимо\n2 -- Я умею работать в авральном режиме\n3 -- Мне становится интересно, когда «горят сроки»\n4 -- Мне нравится напряженная атмосфера на работе\n5 -- Стресс стимулирует меня работать лучше",
    "0 -- Я постоянно опаздываю и пропускаю дедлайны\n1 -- Я готов делать все вовремя, если это необходимо\n2 -- Я умею соблюдать дедлайны и делаю это\n3 -- В моих интересах делать все заранее\n4 -- Мне нравится, когда все сделано заранее\n5 -- Я всегда прихожу заранее и делаю все вовремя",
    "0 -- Я теряюсь, когда информации слишком много\n1 -- Я готов обрабатывать объемные данные, если это необходимо\n2 -- Я умею работать с большими данными и делаю это\n3 -- Мне интересно обрабатывать объемные массивы информации\n4 -- Мне нравится работать с большим объемом информации\n5 -- Я люблю структурировать информацию вне зависимости от ее объема"
    };


    int n = 15;
    int[] mycomp = new int[n];
    int j = 0;
    do
    {
        Console.WriteLine("Вопрос № " + (j + 1) + ". " + compName[j] + compDescription[j] + "\n" + compAnswer[j]);
        mycomp[j] = Defense(compName[j]);
        j++;
    }
    while (j < n);

    Console.WriteLine("\n\n");
    for (int k = 0; k < n; k++)
    {
        Console.Write($"[{compName[k]}: {mycomp[k]}], ");
    }

    Console.Write("\b\b.");
    Console.WriteLine("\n");


    PrintComp(mycomp);

}

int Defense(string txt)
{
    int i;
    do
    {
        do
        {
            Console.Write($"Оцените компетенцию: {txt} (от 0 до 5 [0, 5]): ");
        } while (!int.TryParse(Console.ReadLine(), out i));


    } while (i < 0 || i > 5);
    return i;
}


koleso();


