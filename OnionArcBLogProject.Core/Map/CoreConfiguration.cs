﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic;
using OnionArcBLogProject.Core.Entity;

namespace OnionArcBLogProject.Core.Map
{
    public abstract class CoreConfiguration<T> : IEntityTypeConfiguration<T> where T : CoreEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(t0 => t0.Id);

            builder.Property(t0 => t0.Status).IsRequired(true);

            builder.Property(p=>p.CreatedDate).IsRequired(false);

            builder.Property(p=>p.CreatedComputerName).IsRequired(false).HasMaxLength(255);

            builder.Property(t0 => t0.CreatedIp).IsRequired(false).HasMaxLength(20);

            builder.Property(p => p.ModifiedDate).IsRequired(false);

            builder.Property(p => p.ModifiedComputerName).IsRequired(false).HasMaxLength(255);

            builder.Property(t0 => t0.ModifiedIp).IsRequired(false).HasMaxLength(20);

        }
    }
}
