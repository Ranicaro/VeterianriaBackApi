using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeterianriaBackApi.Data;
using VeterianriaBackApi.Models;
using VeterianriaBackApi.Models.SubModels;
using System;
namespace VeterianriaBackApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeterinariaController : ControllerBase
    {
        public readonly DBVeterinariaV1Context _context;

        public VeterinariaController(DBVeterinariaV1Context context)
        {
            _context = context;
        }


        [HttpPost]
        [Route("/PostCrearUsuarios")]
        public async Task<IActionResult> PostCrearUsuarios(MUsuarios mUsuario)
        {
            try
            {
                var res = await CrearUsuario(mUsuario);
                return Ok(res);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("/GetListarUsuarios")]
        public async Task<IActionResult> GetListarUsuarios()
        {
            try
            {
                var res = await ListaUsuarios();

                if (res == null)
                {
                    return BadRequest("Error listando los usuarios");

                }
                else
                {
                    return Ok(res);
                }

                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("/PostCrearIdentficacion")]
        public async Task<IActionResult> PostCrearIdentficacion(MIdentificacion mIdentificacion)
        {
            try
            {
                var res = await CrearIdentificacion(mIdentificacion);
                return Ok(res);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("/GetListarIdentificaciones")]
        public async Task<IActionResult> GetListarIdentificaciones()
        {
            try
            {
                var res = await ListarIdentificacion();

                if (res == null)
                {
                    return BadRequest("Error listando las identificaciones");

                }
                else
                {
                    return Ok(res);
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("/PostCrearRol")]
        public async Task<IActionResult> PostCrearRol(MRol mRol)
        {
            try
            {
                var res = await CrearRol(mRol);
                return Ok(res);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("/GetListarRol")]
        public async Task<IActionResult> GetListarRol()
        {
            try
            {
                var res = await ListarRol();

                if (res == null)
                {
                    return BadRequest("Error listando los roles");

                }
                else
                {
                    return Ok(res);
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }


        [HttpPost]
        [Route("/PostCrearMascota")]
        public async Task<IActionResult> PostCrearMascota(MMascotas mMascota)
        {
            try
            {
                var res = await CrearMascota(mMascota);
                return Ok(res);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("/GetListarMascotas")]
        public async Task<IActionResult> GetListarMascotas()
        {
            try
            {
                var res = await ListarMascota();

                if (res == null)
                {
                    return BadRequest("Error listando los roles");

                }
                else
                {
                    return Ok(res);
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpPost]
        [Route("/PostListarMascotasId")]
        public async Task<IActionResult> PostListarMascotasId(MListarMascotasId mascota)
        {
            try
            {
                var res = await ListarMascotaId(mascota);

                if (res == null)
                {
                    return BadRequest("Error listando los roles");

                }
                else
                {
                    return Ok(res);
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPut]
        [Route("/PutEditarMascota")]
        public async Task<IActionResult> PutEditarMascota(MMascotas mMascota)
        {
            try
            {
                var res = await EditarMascota(mMascota);
                return Ok(res);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpDelete]
        [Route("/DeleteEliminarMascota")]
        public async Task<IActionResult> DeleteEliminarMascota(MEliminarMascotasId mascota)
        {
            try
            {
                var res = await EliminarMascota(mascota);
                return Ok(res);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        //------------metodos
        private async Task<string> CrearUsuario(MUsuarios mUsuario)
        {
            try
            {
                tblUsuarios tUsuario = new tblUsuarios();
                tUsuario.dtFechaCreacion = DateTime.Now;
                tUsuario.bActivo = true;
                mUsuario.iIDTipoIdentificacion = mUsuario.iIDTipoIdentificacion;
                tUsuario.tNumeroIdentificacion = mUsuario.tNumeroIdentificacion;
                tUsuario.tPrimerNombre = mUsuario.tPrimerNombre;
                tUsuario.tSegundoNombre = mUsuario.tSegundoNombre;

                tUsuario.tPrimerApellido = mUsuario.tPrimerApellido;
                tUsuario.tSegundoApellido = mUsuario.tSegundoApellido;
                tUsuario.tNumeroTelefono = mUsuario.tNumeroTelefono;
                tUsuario.tDireccion = mUsuario.tDireccion;
                tUsuario.tCorreo = mUsuario.tCorreo;
                tUsuario.tContrasenna = mUsuario.tContrasenna;

                _context.Add(tUsuario);
                await _context.SaveChangesAsync();
                return "usuario "+ tUsuario.tPrimerNombre +" "+ tUsuario.tPrimerApellido+" Creado correctamente";

            }
            catch (Exception ex)
            {
                return "Error creando el usuario - excepcion "+ex;               
            }
        }
        
        private async Task<List<MListaUsuarios>?> ListaUsuarios()
        {
            try
            {

                var usuarios = await (from usuario in _context.tblUsuarios
                                      join rol in _context.tblRol on usuario.iIDRol equals rol.iIDRol
                                      join identificacion in _context.tblIdentificacion on usuario.iIDTipoIdentificacion equals identificacion.iIDIdentificacion
                                      select new MListaUsuarios
                                      {
                                          iIDUsuario=usuario.iIDUsuario,
                                          iIDTipoIdentificacion=usuario.iIDTipoIdentificacion,
                                          tTipoIdentificacion=identificacion.tSiglasIdentificacion,
                                          tNumeroIdentificacion=usuario.tNumeroIdentificacion,
                                          tPrimerNombre=usuario.tPrimerNombre,
                                          tSegundoNombre=usuario.tSegundoNombre,
                                          tPrimerApellido=usuario.tPrimerApellido,
                                          tSegundoApellido=usuario.tSegundoApellido,
                                          tNumeroTelefono=usuario.tNumeroTelefono,
                                          tDireccion=usuario.tDireccion,
                                          tCorreo=usuario.tCorreo,
                                          iIDRol=usuario.iIDRol,
                                          tRol=rol.tRol,
                                          iIDUsuarioCreacion=usuario.iIDUsuarioCreacion,
                                         dtFechaCreacion=usuario.dtFechaCreacion 


                                      }).ToListAsync();
                return usuarios;
            }
            catch (Exception ex)
            {
                return null;
                
            }
        }


        private async Task<string> CrearIdentificacion(MIdentificacion mIdentificacion)
        {
            try
            {
                tblIdentificacion tIdentificacion = new tblIdentificacion();
                tIdentificacion.iIDUsuarioCreacion = mIdentificacion.iIDUsuarioCreacion;
                tIdentificacion.dtFechaCreacion = DateTime.Now;
                tIdentificacion.bActivo = true;

                tIdentificacion.tSiglasIdentificacion = mIdentificacion.tSiglasIdentificacion;
                tIdentificacion.tIdentificacion = mIdentificacion.tIdentificacion;

                _context.Add(tIdentificacion);
                await _context.SaveChangesAsync();

                return "Identificacion " + tIdentificacion.tIdentificacion + " Creada correctamente";
            }
            catch (Exception ex)
            {
                return " Error crando la identificacion - excepcion" + ex;

            }
        }



        private async Task<List<MListaIdentificacion>?> ListarIdentificacion()
        {
            try
            {
                var identificaciones = await (from identificacion in _context.tblIdentificacion
                                              where identificacion.bActivo==true
                                              select new MListaIdentificacion
                                              {
                                                  iIDIdentificacion=identificacion.iIDIdentificacion,
                                                  tSiglasIdentificacion=identificacion.tSiglasIdentificacion,
                                                  tIdentificacion=identificacion.tIdentificacion

                                              }).ToListAsync();
                return identificaciones;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        private async Task<string> CrearRol(MRol mRol)
        {
            try
            {
                tblRol tRol = new tblRol();
                tRol.iIDUsuarioCreacion = mRol.iIDUsuarioCreacion;
                tRol.dtFechaCreacion = DateTime.Now;
                tRol.bActivo = true;

                tRol.tRol = mRol.tRol;
                tRol.tDescripcion = mRol.tDescripcion;

                _context.Add(tRol);
                await _context.SaveChangesAsync();

                return "Rol " + tRol.tRol + " Creado correctamente";
            }
            catch (Exception ex)
            {
                return " Error creando la identificacion - excepcion" + ex;

            }
        }
        private async Task<List<MListaRol>?> ListarRol()
        {
            try
            {
                var identificaciones = await (from rol in _context.tblRol
                                              
                                              select new MListaRol
                                              {
                                                 iIDRol=rol.iIDRol,
                                                 tRol=rol.tRol,
                                                 tDescripcion=rol.tDescripcion

                                              }).ToListAsync();
                return identificaciones;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        private async Task<string> CrearMascota(MMascotas mMascota)
        {
            try
            {
                tblMascotas tMascota = new tblMascotas();
                tMascota.iIDUsuarioCreacion = mMascota.iIDUsuarioCreacion;
                tMascota.dtFechaCreacion = DateTime.Now;
                tMascota.bActivo = true;

                tMascota.tNombreMascota = mMascota.tNombreMascota;
                tMascota.tEspecie = mMascota.tEspecie;
                tMascota.tRaza = mMascota.tRaza;
                tMascota.dtFechaNacimiento = mMascota.dtFechaNacimiento;
                tMascota.iIDDuenno = mMascota.iIDDuenno;


                _context.Add(tMascota);
                await _context.SaveChangesAsync();

                return "Mascota " + tMascota.tNombreMascota + " Creado correctamente";
            }
            catch (Exception ex)
            {
                return " Error creando la mascota - excepcion" + ex;

            }
        }

        private async Task<List<MListaMacotas>?> ListarMascota()
        {
            try
            {
                var Mascotas = await (from mascota in _context.tblMascotas
                                      join duenno in _context.tblUsuarios on mascota.iIDDuenno equals duenno.iIDUsuario
                                      select new MListaMacotas
                                      {
                                          iIDMascota = mascota.iIDMascota,
                                          tNombreMascota = mascota.tNombreMascota,
                                          tEspecie = mascota.tEspecie,
                                          tRaza = mascota.tRaza,
                                          dtFechaNacimiento = mascota.dtFechaNacimiento,
                                          iIDDuenno = mascota.iIDDuenno,
                                          tNombreDuenno = duenno.tPrimerNombre,
                                          tTelefonoDuenno = duenno.tNumeroTelefono

                                      }).ToListAsync();
                return Mascotas;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        private async Task<List<MListaMacotas>?> ListarMascotaId(MListarMascotasId MLmascota)
        {
            try
            {
                var Mascotas = await (from mascota in _context.tblMascotas
                                        join duenno in _context.tblUsuarios on mascota.iIDDuenno equals duenno.iIDUsuario
                                        where mascota.iIDMascota==MLmascota.iIDMascota
                                        select new MListaMacotas
                                        {
                                            iIDMascota = mascota.iIDMascota,
                                            tNombreMascota = mascota.tNombreMascota,
                                            tEspecie = mascota.tEspecie,
                                            tRaza = mascota.tRaza,
                                            dtFechaNacimiento = mascota.dtFechaNacimiento,
                                            iIDDuenno = mascota.iIDDuenno,
                                            tNombreDuenno = duenno.tPrimerNombre,
                                            tTelefonoDuenno = duenno.tNumeroTelefono

                                        }).ToListAsync();
                return Mascotas;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        private async Task<string> EditarMascota(MMascotas mMascota)
        {
            try
            {
                tblMascotas tMascota = _context.tblMascotas.Where(x=> x.iIDMascota==mMascota.iIDMascota).FirstOrDefault();
                tMascota.iIDUsuarioCreacion = mMascota.iIDUsuarioCreacion;
                tMascota.dtFechaCreacion = DateTime.Now;
                tMascota.bActivo = true;

                tMascota.tNombreMascota = mMascota.tNombreMascota;
                tMascota.tEspecie = mMascota.tEspecie;
                tMascota.tRaza = mMascota.tRaza;
                tMascota.dtFechaNacimiento = mMascota.dtFechaNacimiento;
                tMascota.iIDDuenno = mMascota.iIDDuenno;


                _context.Entry(tMascota).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return "Mascota " + tMascota.tNombreMascota + " editada correctamente";
            }
            catch (Exception ex)
            {
                return " Error editando mla mascota - excepcion" + ex;

            }
        }
        private async Task<string> EliminarMascota(MEliminarMascotasId mMascota)
        {
            try
            {
                tblMascotas tMascota = _context.tblMascotas.Where(x => x.iIDMascota == mMascota.iIDMascota).FirstOrDefault();



                _context.Remove(tMascota);
                await _context.SaveChangesAsync();

                return "Mascota " + tMascota.tNombreMascota + " Aliminada correctamente";
            }
            catch (Exception ex)
            {
                return " Error editando mla mascota - excepcion" + ex;

            }
        }

        //------

    }
}
