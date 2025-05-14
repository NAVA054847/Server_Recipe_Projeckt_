using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Data;


public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<IngredientsTable> IngredientsTables { get; set; }

    public virtual DbSet<IngredientsrecipeTable> IngredientsrecipeTables { get; set; }

    public virtual DbSet<RecipeTable> RecipeTables { get; set; }

    public virtual DbSet<UserTable> UserTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=MyDB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IngredientsTable>(entity =>
        {
            entity.HasKey(e => e.IdIngredients);

            entity.ToTable("INGREDIENTS-TABLE");

            entity.Property(e => e.IdIngredients).HasColumnName("Id_Ingredients");
            entity.Property(e => e.NameIngredients)
                .HasMaxLength(50)
                .HasColumnName("Name_Ingredients");
        });

        modelBuilder.Entity<IngredientsrecipeTable>(entity =>
        {
            entity.HasKey(e => e.IdIngredientsRecipe);

            entity.ToTable("INGREDIENTSRECIPE_TABLE");

            entity.Property(e => e.IdIngredientsRecipe).HasColumnName("Id_IngredientsRecipe");
            entity.Property(e => e.IdIngredientsIngredientsRecipe).HasColumnName("IdIngredients_IngredientsRecipe");
            entity.Property(e => e.IdRecipeIngredientsRecipe).HasColumnName("IdRecipe_IngredientsRecipe");
            entity.Property(e => e.UnitsIngredientsRecipe)
                .HasMaxLength(50)
                .HasColumnName("Units_IngredientsRecipe");

            entity.HasOne(d => d.IdIngredientsIngredientsRecipeNavigation).WithMany(p => p.IngredientsrecipeTables)
                .HasForeignKey(d => d.IdIngredientsIngredientsRecipe)
                .HasConstraintName("FK_INGREDIENTSRECIPE_TABLE_INGREDIENTS-TABLE");

            entity.HasOne(d => d.IdRecipeIngredientsRecipeNavigation).WithMany(p => p.IngredientsrecipeTables)
                .HasForeignKey(d => d.IdRecipeIngredientsRecipe)
                .HasConstraintName("FK_INGREDIENTSRECIPE_TABLE_RECIPE_TABLE");
        });

        modelBuilder.Entity<RecipeTable>(entity =>
        {
            entity.HasKey(e => e.IdRecipe);

            entity.ToTable("RECIPE_TABLE");

            entity.Property(e => e.IdRecipe).HasColumnName("Id__Recipe");
            entity.Property(e => e.DescriptionRecipe)
                .HasMaxLength(50)
                .HasColumnName("Description_Recipe");
            entity.Property(e => e.IdUser).HasColumnName("Id_User");
            entity.Property(e => e.ImgRecipe)
                .HasMaxLength(50)
                .HasColumnName("Img_Recipe");
            entity.Property(e => e.InstructionsRecipe)
                .HasMaxLength(200)
                .HasColumnName("Instructions_Recipe");
            entity.Property(e => e.LevelRecipe)
                .HasMaxLength(50)
                .HasColumnName("Level_Recipe");
            entity.Property(e => e.MinuteTimeRecipe).HasColumnName("MinuteTime_Recipe");
            entity.Property(e => e.NameRecipe)
                .HasMaxLength(50)
                .HasColumnName("Name_Recipe");
            entity.Property(e => e.UnitsRecipe).HasColumnName("Units_Recipe");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.RecipeTables)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_RECIPE_TABLE_USER_TABLE");
        });

        modelBuilder.Entity<UserTable>(entity =>
        {
            entity.ToTable("USER_TABLE");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Lastname).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
