using AutoMapper;

namespace Utililies
{
    public static class Utilities
    {
        /// <summary>
        /// Converts the object "entity" of type U to an object of type T.
        /// </summary>
        /// <typeparam name="T">Destiny class</typeparam>
        /// <typeparam name="U">Origin class</typeparam>
        /// <param name="entity">object to convert</param>
        /// <returns></returns>
        public static T Map<T, U>(U obj) // T es el tipo de dato que queremos devolver, U es el tipo de dato que recibimos
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<U, T>()); // creamos una instancia de MapperConfiguration y le decimos que queremos mapear de U a T
            var mapper = config.CreateMapper(); // creamos una instancia de Mapper a partir de la configuracion anterior y la guardamos en mapper
            return mapper.Map<U, T>(obj); // devolvemos el resultado del mapeo de entity a T usando mapper
        }
        /// <summary>
        /// Converts an UserDTO to an UserEntity to create a new user.
        /// </summary>
        /// <typeparam name="T">UserEntity</typeparam>
        /// <typeparam name="U">UserDTO</typeparam>
        /// <param name="user">UserDTO</param>
        /// <param name="password"></param>
        /// <returns></returns>
    }
}
