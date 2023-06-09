﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistencia.DataBases;

#nullable disable

namespace Persistencia.Migrations
{
    [DbContext(typeof(WebApiContext))]
    [Migration("20230605184833_v_1")]
    partial class v_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasColumnName("claimtype");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text")
                        .HasColumnName("claimvalue");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("roleid");

                    b.HasKey("Id")
                        .HasName("pk_aspnetroleclaims");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_aspnetroleclaims_roleid");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasColumnName("claimtype");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text")
                        .HasColumnName("claimvalue");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("userid");

                    b.HasKey("Id")
                        .HasName("pk_aspnetuserclaims");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_aspnetuserclaims_userid");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text")
                        .HasColumnName("loginprovider");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text")
                        .HasColumnName("providerkey");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text")
                        .HasColumnName("providerdisplayname");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("userid");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("pk_aspnetuserlogins");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_aspnetuserlogins_userid");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("userid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text")
                        .HasColumnName("loginprovider");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("pk_aspnetusertokens");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.Arquivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("integer")
                        .HasColumnName("categoriaid");

                    b.Property<DateTime?>("DataHoraEnvio")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("datahoraenvio");

                    b.Property<DateTime?>("DataVencimento")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("datavencimento");

                    b.Property<int?>("EstabelecimentoId")
                        .HasColumnType("integer")
                        .HasColumnName("estabelecimentoid");

                    b.Property<string>("NomeArquivo")
                        .HasColumnType("text")
                        .HasColumnName("nomearquivo");

                    b.Property<string>("NomeArquivoStorage")
                        .HasColumnType("text")
                        .HasColumnName("nomearquivostorage");

                    b.Property<int?>("TamanhoEmBytes")
                        .HasColumnType("integer")
                        .HasColumnName("tamanhoembytes");

                    b.Property<int?>("TicketInteracaoId")
                        .HasColumnType("integer")
                        .HasColumnName("ticketinteracaoid");

                    b.Property<string>("Uri")
                        .HasColumnType("text")
                        .HasColumnName("uri");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("integer")
                        .HasColumnName("usuarioid");

                    b.HasKey("Id")
                        .HasName("pk_arquivos");

                    b.HasIndex("EstabelecimentoId")
                        .HasDatabaseName("ix_arquivos_estabelecimentoid");

                    b.HasIndex("UsuarioId")
                        .HasDatabaseName("ix_arquivos_usuarioid");

                    b.ToTable("arquivos", (string)null);
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.EstabelecimentoImagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ImagemLogomarcaId")
                        .HasColumnType("integer")
                        .HasColumnName("imagemlogomarcaid");

                    b.Property<string>("NomeArquivoStorage")
                        .HasColumnType("text")
                        .HasColumnName("nomearquivostorage");

                    b.Property<string>("NomeImagem")
                        .HasColumnType("text")
                        .HasColumnName("nomeimagem");

                    b.Property<string>("Uri")
                        .HasColumnType("text")
                        .HasColumnName("uri");

                    b.HasKey("Id")
                        .HasName("pk_estabelecimentosimagens");

                    b.HasIndex("ImagemLogomarcaId")
                        .IsUnique()
                        .HasDatabaseName("ix_estabelecimentosimagens_imagemlogomarcaid");

                    b.ToTable("estabelecimentosimagens", (string)null);
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text")
                        .HasColumnName("concurrencystamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<int>("NivelAcesso")
                        .HasColumnType("integer")
                        .HasColumnName("nivelacesso");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalizedname");

                    b.Property<int>("TipoAcesso")
                        .HasColumnType("integer")
                        .HasColumnName("tipoacesso");

                    b.HasKey("Id")
                        .HasName("pk_perfis");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("perfis", (string)null);
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer")
                        .HasColumnName("accessfailedcount");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Celular")
                        .HasColumnType("text")
                        .HasColumnName("celular");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text")
                        .HasColumnName("concurrencystamp");

                    b.Property<DateTime>("DataDaCriacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("datadacriacao");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("emailconfirmed");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("lockoutenabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lockoutend");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalizedemail");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalizedusername");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text")
                        .HasColumnName("senha");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("telefone");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("phonenumberconfirmed");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text")
                        .HasColumnName("securitystamp");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("twofactorenabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("nome");

                    b.HasKey("Id")
                        .HasName("pk_usuarios");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("usuarios", (string)null);
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.UsuarioEstabelecimento", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer")
                        .HasColumnName("usuarioid");

                    b.Property<int>("EstabelecimentoId")
                        .HasColumnType("integer")
                        .HasColumnName("estabelecimentoid");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.HasKey("UsuarioId", "EstabelecimentoId")
                        .HasName("pk_usuariosestabelecimentos");

                    b.HasIndex("EstabelecimentoId")
                        .HasDatabaseName("ix_usuariosestabelecimentos_estabelecimentoid");

                    b.ToTable("usuariosestabelecimentos", (string)null);
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.UsuarioImagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeArquivoStorage")
                        .HasColumnType("text")
                        .HasColumnName("nomearquivostorage");

                    b.Property<string>("NomeImagem")
                        .HasColumnType("text")
                        .HasColumnName("nomeimagem");

                    b.Property<string>("Uri")
                        .HasColumnType("text")
                        .HasColumnName("uri");

                    b.Property<int>("UsuarioImagemId")
                        .HasColumnType("integer")
                        .HasColumnName("usuarioimagemid");

                    b.HasKey("Id")
                        .HasName("pk_usuariosimagens");

                    b.HasIndex("UsuarioImagemId")
                        .IsUnique()
                        .HasDatabaseName("ix_usuariosimagens_usuarioimagemid");

                    b.ToTable("usuariosimagens", (string)null);
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.UsuarioLinkTemporario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("TipoDeLinkTemporario")
                        .HasColumnType("integer")
                        .HasColumnName("tipodelinktemporario");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("integer")
                        .HasColumnName("usuarioid");

                    b.Property<DateTime>("ValidoAte")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("validoate");

                    b.HasKey("Id")
                        .HasName("pk_usuarioslinkstemporarios");

                    b.HasIndex("UsuarioId")
                        .HasDatabaseName("ix_usuarioslinkstemporarios_usuarioid");

                    b.ToTable("usuarioslinkstemporarios", (string)null);
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.UsuarioPerfil", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("userid");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("roleid");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_usuariosperfis");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_usuariosperfis_roleid");

                    b.ToTable("usuariosperfis", (string)null);
                });

            modelBuilder.Entity("Persistencia.Models.Geral.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<int>("CodigoEmpresa")
                        .HasColumnType("integer")
                        .HasColumnName("codigoempresa");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("text")
                        .HasColumnName("nomefantasia");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("text")
                        .HasColumnName("razaosocial");

                    b.HasKey("Id")
                        .HasName("pk_empresas");

                    b.ToTable("empresas", (string)null);
                });

            modelBuilder.Entity("Persistencia.Models.Geral.Estabelecimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Bairro")
                        .HasColumnType("text")
                        .HasColumnName("bairro");

                    b.Property<string>("Caepf")
                        .HasColumnType("text")
                        .HasColumnName("caepf");

                    b.Property<string>("Cei")
                        .HasColumnType("text")
                        .HasColumnName("cei");

                    b.Property<string>("Celular")
                        .HasColumnType("text")
                        .HasColumnName("celular");

                    b.Property<string>("Cep")
                        .HasColumnType("text")
                        .HasColumnName("cep");

                    b.Property<string>("CnpjCpf")
                        .HasColumnType("text")
                        .HasColumnName("cnpjcpf");

                    b.Property<int>("CodigoEstabelecimento")
                        .HasColumnType("integer")
                        .HasColumnName("codigoestabelecimento");

                    b.Property<int>("CodigoMunicipio")
                        .HasColumnType("integer")
                        .HasColumnName("codigomunicipio");

                    b.Property<string>("ComplementoEndereco")
                        .HasColumnType("text")
                        .HasColumnName("complementoendereco");

                    b.Property<int?>("ContadorId")
                        .HasColumnType("integer")
                        .HasColumnName("contadorid");

                    b.Property<DateTime>("DataAlteracaoSociedadeSimples")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dataalteracaosociedadesimples");

                    b.Property<DateTime>("DataRegistroContrato")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dataregistrocontrato");

                    b.Property<string>("DddCelular")
                        .HasColumnType("text")
                        .HasColumnName("dddcelular");

                    b.Property<string>("DddTelefone")
                        .HasColumnType("text")
                        .HasColumnName("dddtelefone");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer")
                        .HasColumnName("empresaid");

                    b.Property<string>("Endereco")
                        .HasColumnType("text")
                        .HasColumnName("endereco");

                    b.Property<DateTime?>("InicioAtividade")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("inicioatividade");

                    b.Property<string>("InscricaoAntt")
                        .HasColumnType("text")
                        .HasColumnName("inscricaoantt");

                    b.Property<string>("InscricaoBancoCentral")
                        .HasColumnType("text")
                        .HasColumnName("inscricaobancocentral");

                    b.Property<string>("InscricaoCvm")
                        .HasColumnType("text")
                        .HasColumnName("inscricaocvm");

                    b.Property<string>("InscricaoEstadual")
                        .HasColumnType("text")
                        .HasColumnName("inscricaoestadual");

                    b.Property<string>("InscricaoMunicipal")
                        .HasColumnType("text")
                        .HasColumnName("inscricaomunicipal");

                    b.Property<string>("InscricaoSubstitutoTributario")
                        .HasColumnType("text")
                        .HasColumnName("inscricaosubstitutotributario");

                    b.Property<string>("InscricaoSuframa")
                        .HasColumnType("text")
                        .HasColumnName("inscricaosuframa");

                    b.Property<string>("InscricaoSusep")
                        .HasColumnType("text")
                        .HasColumnName("inscricaosusep");

                    b.Property<string>("InscricaoTse")
                        .HasColumnType("text")
                        .HasColumnName("inscricaotse");

                    b.Property<string>("LinkBpo")
                        .HasColumnType("text")
                        .HasColumnName("linkbpo");

                    b.Property<string>("LocalRegistroContrato")
                        .HasColumnType("text")
                        .HasColumnName("localregistrocontrato");

                    b.Property<string>("Nickname")
                        .HasColumnType("text")
                        .HasColumnName("nickname");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("text")
                        .HasColumnName("nomefantasia");

                    b.Property<string>("NomeMunicipio")
                        .HasColumnType("text")
                        .HasColumnName("nomemunicipio");

                    b.Property<string>("NumeroAlvara")
                        .HasColumnType("text")
                        .HasColumnName("numeroalvara");

                    b.Property<string>("NumeroEndereco")
                        .HasColumnType("text")
                        .HasColumnName("numeroendereco");

                    b.Property<string>("NumeroRegistroContrato")
                        .HasColumnType("text")
                        .HasColumnName("numeroregistrocontrato");

                    b.Property<bool>("PossuiNire")
                        .HasColumnType("boolean")
                        .HasColumnName("possuinire");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("text")
                        .HasColumnName("razaosocial");

                    b.Property<string>("RazaoSocialCompleta")
                        .HasColumnType("text")
                        .HasColumnName("razaosocialcompleta");

                    b.Property<string>("Telefone")
                        .HasColumnType("text")
                        .HasColumnName("telefone");

                    b.Property<string>("Uf")
                        .HasColumnType("text")
                        .HasColumnName("uf");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("integer")
                        .HasColumnName("usuarioid");

                    b.HasKey("Id")
                        .HasName("pk_estabelecimentos");

                    b.HasIndex("EmpresaId")
                        .HasDatabaseName("ix_estabelecimentos_empresaid");

                    b.HasIndex("UsuarioId")
                        .HasDatabaseName("ix_estabelecimentos_usuarioid");

                    b.ToTable("estabelecimentos", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Persistencia.Models.EFolha.Perfil", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_aspnetroleclaims_aspnetroles_roleid");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Persistencia.Models.EFolha.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_aspnetuserclaims_aspnetusers_userid");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Persistencia.Models.EFolha.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_aspnetuserlogins_aspnetusers_userid");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Persistencia.Models.EFolha.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_aspnetusertokens_aspnetusers_userid");
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.Arquivo", b =>
                {
                    b.HasOne("Persistencia.Models.Geral.Estabelecimento", "Estabelecimento")
                        .WithMany("Arquivos")
                        .HasForeignKey("EstabelecimentoId")
                        .HasConstraintName("fk_arquivos_estabelecimentos_estabelecimentoid");

                    b.HasOne("Persistencia.Models.EFolha.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("fk_arquivos_aspnetusers_usuarioid");

                    b.Navigation("Estabelecimento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.EstabelecimentoImagem", b =>
                {
                    b.HasOne("Persistencia.Models.Geral.Estabelecimento", null)
                        .WithOne("ImagemLogoMarca")
                        .HasForeignKey("Persistencia.Models.EFolha.EstabelecimentoImagem", "ImagemLogomarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_estabelecimentosimagens_estabelecimentos_imagemlogomarcaid");
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.UsuarioEstabelecimento", b =>
                {
                    b.HasOne("Persistencia.Models.Geral.Estabelecimento", "Estabelecimento")
                        .WithMany("UsuariosEstabelecimentos")
                        .HasForeignKey("EstabelecimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_usuariosestabelecimentos_estabelecimentos_estabelecimentoid");

                    b.HasOne("Persistencia.Models.EFolha.Usuario", "Usuario")
                        .WithMany("UsuariosEstabelecimentos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_usuariosestabelecimentos_usuario_usuarioid");

                    b.Navigation("Estabelecimento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.UsuarioImagem", b =>
                {
                    b.HasOne("Persistencia.Models.EFolha.Usuario", null)
                        .WithOne("Imagem")
                        .HasForeignKey("Persistencia.Models.EFolha.UsuarioImagem", "UsuarioImagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_usuariosimagens_usuarios_usuarioimagemid");
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.UsuarioLinkTemporario", b =>
                {
                    b.HasOne("Persistencia.Models.EFolha.Usuario", "Usuario")
                        .WithMany("LinkTemporarios")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("fk_usuarioslinkstemporarios_usuario_usuarioid");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.UsuarioPerfil", b =>
                {
                    b.HasOne("Persistencia.Models.EFolha.Perfil", "Perfil")
                        .WithMany("UsuariosPerfis")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_usuariosperfis_perfis_roleid");

                    b.HasOne("Persistencia.Models.EFolha.Usuario", "Usuario")
                        .WithMany("UsuariosPerfis")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_usuariosperfis_usuarios_userid");

                    b.Navigation("Perfil");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Persistencia.Models.Geral.Estabelecimento", b =>
                {
                    b.HasOne("Persistencia.Models.Geral.Empresa", "Empresa")
                        .WithMany("Estabelecimentos")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_estabelecimentos_empresas_empresaid");

                    b.HasOne("Persistencia.Models.EFolha.Usuario", null)
                        .WithMany("Estabelecimentos")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("fk_estabelecimentos_usuario_usuarioid");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.Perfil", b =>
                {
                    b.Navigation("UsuariosPerfis");
                });

            modelBuilder.Entity("Persistencia.Models.EFolha.Usuario", b =>
                {
                    b.Navigation("Estabelecimentos");

                    b.Navigation("Imagem");

                    b.Navigation("LinkTemporarios");

                    b.Navigation("UsuariosEstabelecimentos");

                    b.Navigation("UsuariosPerfis");
                });

            modelBuilder.Entity("Persistencia.Models.Geral.Empresa", b =>
                {
                    b.Navigation("Estabelecimentos");
                });

            modelBuilder.Entity("Persistencia.Models.Geral.Estabelecimento", b =>
                {
                    b.Navigation("Arquivos");

                    b.Navigation("ImagemLogoMarca");

                    b.Navigation("UsuariosEstabelecimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
