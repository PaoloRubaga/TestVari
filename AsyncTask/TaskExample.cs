namespace AsyncTask
{
    internal static class TaskExample
    {
        public static void TaskAction(string action, int time)
        {
            Console.WriteLine($"inizio di {action}");
            Thread.Sleep(time);
            Console.WriteLine($"fine di {action}");
        }

        public static async Task TaskRunExample()
        {
            var task1 = Task.Run(() => TaskAction("task1.run", 1000));
            var task2 = Task.Run(() => TaskAction("task2.run", 2000));
            var task3 = Task.Run(() => TaskAction("task3.run", 3000));

            await task1;
            await task2;
            await task3;
        }

        public static async Task TaskStartExample()
        {
            var task1 = Task.Factory.StartNew(
                () => TaskAction("Task.Factory.StartNew1.run", 1000));
            var task2 = Task.Factory.StartNew(
                () => TaskAction("Task.Factory.StartNew2.run", 2000));
            var task3 = Task.Factory.StartNew(
                () => TaskAction("Task.Factory.StartNew3.run", 3000));

            await task1;
            await task2;
            await task3;
        }



        public static async Task Execute()
        {
            Console.WriteLine("----------------- Task.run inizio ---------------");
            await TaskRunExample();
            Console.WriteLine("----------------- Task.run fine ---------------");

            Console.WriteLine("----------------- Task.Factory.StartNew inizio ---------------");
            await TaskStartExample();
            Console.WriteLine("----------------- Task.Factory.StartNew fine ---------------");
        }
    }
}
