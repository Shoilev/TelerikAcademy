﻿using System;
using System.Collections.Generic;

public class Course
{
    public const int MaxStudents = 30;

    private readonly IList<Student> students = new List<Student>();

    public Course(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name must be not be null or empty!");
        }

        this.Name = name;
    }

    public string Name { get; private set; }

    public IEnumerable<Student> Students
    {
        get
        { 
            return this.students;
        }
    }

    public int StudentCount
    {
        get 
        { 
            return this.students.Count;
        }
    }

    public bool IsStudentEnrolled(Student student)
    {
        if (student == null)
        {
            throw new ArgumentNullException("student");
        }

        return this.students.Contains(student);
    }

    public void AddStudent(Student student)
    {
        if (student == null)
        {
            throw new ArgumentNullException("student");
        }

        if (this.students.Count >= MaxStudents)
        {
            throw new InvalidOperationException("Course is full!");
        }

        this.students.Add(student);
    }

    public bool RemoveStudent(Student student)
    {
        if (student == null)
        {
            throw new ArgumentNullException("student");
        }

        return this.students.Remove(student);
    }
}