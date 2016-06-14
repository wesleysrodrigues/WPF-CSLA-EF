using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCE.Entities;

namespace UnitTest.WCE.Entities
{
    [TestClass]
    public class UnitTestRepository
    {
        IRepository<> _repository;

        [TestInitialize]
        public void Initialize()
        {

        }

        [TestMethod]
        public void GetAll()
        {
            _repository.GetAll();
        }

        [TestMethod]
        public void GetById()
        {
            _repository.GetById(0);
        }

        /// <summary>
        /// Criar
        /// </summary>
        [TestMethod]
        public void Create()
        {

        }

        /// <summary>
        /// Altera
        /// </summary>
        [TestMethod]
        public void Update()
        {

        }

        /// <summary>
        /// Criar e salva
        /// </summary>
        [TestMethod]
        public void CreateFlush()
        {

        }

        /// <summary>
        /// Altera e salva
        /// </summary>
        [TestMethod]
        public void UpdateFlush()
        {

        }

        /// <summary>
        /// Deleta
        /// </summary>
        [TestMethod]
        public void Delete()
        {

        }

        /// <summary>
        /// Deleta e salva
        /// </summary>
        [TestMethod]
        public void DeleteFlush()
        {

        }

        [TestMethod]
        public void SaveChanges()
        {

        }

        [TestMethod]
        public void CreateMultiEntitiesInTransation()
        {

        }

        [TestMethod]
        public void UpdateMultiEntitiesInTransation()
        {

        }

        [TestMethod]
        public void DeleteMultiEntitiesInTransation()
        {

        }

        /// <summary>
        /// Buscar um item no banco que não contém o id de procura
        /// É esperado uma exceção do tipo [CRIAR EXCEPTION]
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GetByIdWithoutId()
        {

        }

        /// <summary>
        /// É esperado uma exceção do tipo [CRIAR EXCEPTION]
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CreateNotFieldRequired()
        {

        }

        /// <summary>
        /// É esperado uma exceção do tipo [CRIAR EXCEPTION]
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UpdateNotFieldRequired()
        {

        }

        /// <summary>
        /// Tetando fazer update em um objeto novo
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UpdateEntityNotAttchament()
        {

        }

    }
}
