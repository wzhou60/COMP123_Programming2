﻿//Jackie Zhou 301465524 Lab6/7
namespace JackieZ_301465524_Lab67Library
{
    public class Task
    {
        public string Description
        {
            get; set;
        }

        public bool IsDone
        {
            get; set;
        }

        public DateTime DueDate
        {
            get; set;
        }

        public Guid Id
        {
            get;
            private set;
        }

        public Task(string description)
        {
            Description = description;
            DueDate = DateTime.MinValue;
            IsDone = false;
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            string dueDateString = "";
            if (DueDate == default(DateTime))
            {
                dueDateString = "";
            }
            else
            { dueDateString = $" Due: {DueDate}"; }

            string doneString = "";
            if (IsDone)
            { doneString = "Done"; }
            else
            { doneString = "Not Done"; }

            return $"Task: {Description}{dueDateString} - {doneString}";
        }
    }
}