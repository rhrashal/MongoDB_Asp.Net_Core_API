﻿using MongoDbDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbDotNet.Service
{
    public interface IStudentService
    {
        List<Student> Get();
        Student Get(string id);
        Student Create(Student student);
        void Update(string id, Student student);
        void Remove(string id);
    }
}
