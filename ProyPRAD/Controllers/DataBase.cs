using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ProyPRAD.Models;
using ProyPRAD.Controllers;
using System.Threading.Tasks;

namespace ProyPRAD.Controllers
{
    internal  static class DataBase
    {
        public static SQLiteAsyncConnection dbconexion;
        public static void conexion (string dbpath)
        {
            dbconexion = new SQLiteAsyncConnection(dbpath);
            dbconexion.CreateTableAsync<Contactos>();
            dbconexion.CreateTableAsync<Sitios>();
        }
        public static Task<List<Contactos>> ObtenerListaContactos()
        {
            return dbconexion.Table<Contactos>().ToListAsync();
        }

        public static Task<int> AddContacto(Contactos contacto)
        {
            if (contacto.Id != 0)
            {
                return dbconexion.UpdateAsync(contacto);
            }
            else
            {
                return dbconexion.InsertAsync(contacto);
            }
        }
        public static Task<Contactos> ObtenerContacto(int pid)
        {
            return dbconexion.Table<Contactos>()
                .Where(i => i.Id == pid)
                .FirstOrDefaultAsync();
        }
        public static Task<int> DelContacto(Contactos contacto)
        {
            return dbconexion.DeleteAsync(contacto);
        }
        public static Task<List<Sitios>> ObtenerListaSitios()
        {
            return dbconexion.Table<Sitios>().ToListAsync();
        }
        public static Task<int> AddSitio(Sitios sitio)
        {
            if (sitio.Id != 0)
            {
                return dbconexion.UpdateAsync(sitio);

            }
            else
            {
                return dbconexion.InsertAsync(sitio);
            }
        }
        public static Task<Sitios> ObtenerSitio(int pid)
        {
            return dbconexion.Table<Sitios>().Where(i => i.Id == pid).FirstOrDefaultAsync();
        }
        public static Task<int> DelSitio(Sitios sitio)
        {
            return dbconexion.DeleteAsync(sitio);
        }
    }
}
