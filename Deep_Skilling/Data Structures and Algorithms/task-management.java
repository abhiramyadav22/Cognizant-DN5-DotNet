class Task
{
    int taskId;

    String taskName;

    Task next;

    Task(int taskId,String taskName)
    {
        this.taskId = taskId;

        this.taskName = taskName;
    }
}

class TaskManagement
{
    public static void main(String args[])
    {
        Task t1 =
        new Task(1,"Coding");

        Task t2 =
        new Task(2,"Testing");

        t1.next = t2;

        Task temp = t1;

        while(temp != null)
        {
            System.out.println(temp.taskName);

            temp = temp.next;
        }
    }
}