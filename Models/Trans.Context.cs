﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class TransEntity : DbContext
{
    public TransEntity()
        : base("name=TransEntity")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<tblTransaction> tblTransactions { get; set; }

}

