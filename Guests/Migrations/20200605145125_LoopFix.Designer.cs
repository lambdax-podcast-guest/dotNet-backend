﻿// <auto-generated />
using System;
using Guests.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Guests.Migrations
{
    [DbContext(typeof(AppUserContext))]
    [Migration("20200605145125_LoopFix")]
    partial class LoopFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Guests.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("text");

                    b.Property<string>("AvatarUrl")
                        .HasColumnName("avatar_url")
                        .HasColumnType("text");

                    b.Property<string>("Bio")
                        .HasColumnName("bio")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrency_stamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnName("email_confirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("HeadLine")
                        .HasColumnName("head_line")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string[]>("Languages")
                        .HasColumnName("languages")
                        .HasColumnType("text[]");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Location")
                        .HasColumnName("location")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnName("normalized_email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnName("normalized_user_name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnName("password_hash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnName("phone_number_confirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnName("security_stamp")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnName("user_name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Guests.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id")
                        .HasName("pk_guests");

                    b.ToTable("guests");
                });

            modelBuilder.Entity("Guests.Models.GuestTopic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("GuestId")
                        .IsRequired()
                        .HasColumnName("guest_id")
                        .HasColumnType("text");

                    b.Property<int>("TopicId")
                        .HasColumnName("topic_id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("pk_guest_topics");

                    b.HasIndex("GuestId")
                        .HasName("ix_guest_topics_guest_id");

                    b.HasIndex("TopicId")
                        .HasName("ix_guest_topics_topic_id");

                    b.ToTable("guest_topics");
                });

            modelBuilder.Entity("Guests.Models.Invitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("GuestId")
                        .IsRequired()
                        .HasColumnName("guest_id")
                        .HasColumnType("text");

                    b.Property<string>("HostId")
                        .IsRequired()
                        .HasColumnName("host_id")
                        .HasColumnType("text");

                    b.Property<string>("InvitationText")
                        .HasColumnName("invitation_text")
                        .HasColumnType("text");

                    b.Property<int>("PodcastId")
                        .HasColumnName("podcast_id")
                        .HasColumnType("integer");

                    b.Property<string>("RequestType")
                        .IsRequired()
                        .HasColumnName("request_type")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("pk_invitations");

                    b.HasIndex("GuestId")
                        .HasName("ix_invitations_guest_id");

                    b.HasIndex("HostId")
                        .HasName("ix_invitations_host_id");

                    b.HasIndex("PodcastId")
                        .HasName("ix_invitations_podcast_id");

                    b.ToTable("invitations");
                });

            modelBuilder.Entity("Guests.Models.Podcast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<string>("HeadLine")
                        .HasColumnName("head_line")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("pk_podcasts");

                    b.ToTable("podcasts");
                });

            modelBuilder.Entity("Guests.Models.PodcastGuest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("GuestId")
                        .IsRequired()
                        .HasColumnName("guest_id")
                        .HasColumnType("text");

                    b.Property<int>("PodcastId")
                        .HasColumnName("podcast_id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("pk_podcast_guests");

                    b.HasIndex("GuestId")
                        .HasName("ix_podcast_guests_guest_id");

                    b.HasIndex("PodcastId")
                        .HasName("ix_podcast_guests_podcast_id");

                    b.ToTable("podcast_guests");
                });

            modelBuilder.Entity("Guests.Models.PodcastHost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("HostId")
                        .IsRequired()
                        .HasColumnName("host_id")
                        .HasColumnType("text");

                    b.Property<int>("PodcastId")
                        .HasColumnName("podcast_id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("pk_podcast_hosts");

                    b.HasIndex("HostId")
                        .HasName("ix_podcast_hosts_host_id");

                    b.HasIndex("PodcastId")
                        .HasName("ix_podcast_hosts_podcast_id");

                    b.ToTable("podcast_hosts");
                });

            modelBuilder.Entity("Guests.Models.PodcastTopic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PodcastId")
                        .HasColumnName("podcast_id")
                        .HasColumnType("integer");

                    b.Property<int>("TopicId")
                        .HasColumnName("topic_id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("pk_podcast_topics");

                    b.HasIndex("PodcastId")
                        .HasName("ix_podcast_topics_podcast_id");

                    b.HasIndex("TopicId")
                        .HasName("ix_podcast_topics_topic_id");

                    b.ToTable("podcast_topics");
                });

            modelBuilder.Entity("Guests.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("pk_topics");

                    b.ToTable("topics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 6, 5, 9, 51, 25, 13, DateTimeKind.Local).AddTicks(8532),
                            Name = "Sports",
                            UpdatedAt = new DateTime(2020, 6, 5, 9, 51, 25, 17, DateTimeKind.Local).AddTicks(4055)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 6, 5, 9, 51, 25, 18, DateTimeKind.Local).AddTicks(8774),
                            Name = "Literature",
                            UpdatedAt = new DateTime(2020, 6, 5, 9, 51, 25, 18, DateTimeKind.Local).AddTicks(8810)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrency_stamp")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnName("normalized_name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claim_value")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnName("role_id")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_role_claims");

                    b.HasIndex("RoleId")
                        .HasName("ix_role_claims_role_id");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claim_value")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnName("user_id")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_user_claims");

                    b.HasIndex("UserId")
                        .HasName("ix_user_claims_user_id");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnName("login_provider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnName("provider_key")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnName("provider_display_name")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnName("user_id")
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("pk_user_logins");

                    b.HasIndex("UserId")
                        .HasName("ix_user_logins_user_id");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnName("role_id")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_user_roles");

                    b.HasIndex("RoleId")
                        .HasName("ix_user_roles_role_id");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnName("login_provider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("pk_user_tokens");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Guests.Models.GuestTopic", b =>
                {
                    b.HasOne("Guests.Models.AppUser", "User")
                        .WithMany("GuestTopics")
                        .HasForeignKey("GuestId")
                        .HasConstraintName("fk_guest_topics_users_guest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Guests.Models.Topic", "Topic")
                        .WithMany("GuestTopics")
                        .HasForeignKey("TopicId")
                        .HasConstraintName("fk_guest_topics_topics_topic_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Guests.Models.Invitation", b =>
                {
                    b.HasOne("Guests.Models.AppUser", "GuestUser")
                        .WithMany("Invitations")
                        .HasForeignKey("GuestId")
                        .HasConstraintName("fk_invitations_users_guest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Guests.Models.AppUser", "HostUser")
                        .WithMany()
                        .HasForeignKey("HostId")
                        .HasConstraintName("fk_invitations_users_host_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Guests.Models.Podcast", "Podcast")
                        .WithMany("Invitations")
                        .HasForeignKey("PodcastId")
                        .HasConstraintName("fk_invitations_podcasts_podcast_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Guests.Models.PodcastGuest", b =>
                {
                    b.HasOne("Guests.Models.AppUser", "User")
                        .WithMany("PodcastGuests")
                        .HasForeignKey("GuestId")
                        .HasConstraintName("fk_podcast_guests_users_guest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Guests.Models.Podcast", "Podcast")
                        .WithMany("PodcastGuests")
                        .HasForeignKey("PodcastId")
                        .HasConstraintName("fk_podcast_guests_podcasts_podcast_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Guests.Models.PodcastHost", b =>
                {
                    b.HasOne("Guests.Models.AppUser", "User")
                        .WithMany("PodcastHosts")
                        .HasForeignKey("HostId")
                        .HasConstraintName("fk_podcast_hosts_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Guests.Models.Podcast", "Podcast")
                        .WithMany("PodcastHosts")
                        .HasForeignKey("PodcastId")
                        .HasConstraintName("fk_podcast_hosts_podcasts_podcast_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Guests.Models.PodcastTopic", b =>
                {
                    b.HasOne("Guests.Models.Podcast", "Podcast")
                        .WithMany("PodcastTopics")
                        .HasForeignKey("PodcastId")
                        .HasConstraintName("fk_podcast_topics_podcasts_podcast_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Guests.Models.Topic", "Topic")
                        .WithMany("PodcastTopics")
                        .HasForeignKey("TopicId")
                        .HasConstraintName("fk_podcast_topics_topics_topic_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_role_claims_asp_net_roles_identity_role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Guests.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_claims_asp_net_users_app_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Guests.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_logins_asp_net_users_app_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_user_roles_asp_net_roles_identity_role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Guests.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_roles_asp_net_users_app_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Guests.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_tokens_asp_net_users_app_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
