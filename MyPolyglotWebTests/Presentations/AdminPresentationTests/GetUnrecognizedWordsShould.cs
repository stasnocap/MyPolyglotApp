using AutoMapper;
using Moq;
using MyPolyglotCore.Interfaces;
using MyPolyglotCore.Words;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Repositories.IRepositories;
using System.Collections.Generic;
using Xunit;

namespace MyPolyglotWebTests.Presentations.AdminPresentationTests
{
    public class GetUnrecognizedWordsShould
    {
        private AdminPresentation _adminPresentation;
        private Mock<IMapper> _mapperMock;
        private Mock<ILessonRepository> _lessonRepositoryMock;
        private Mock<IExerciseRepository> _exerciseRepositoryMock;
        private Mock<IUnrecognizedWordRepository> _unrecognizedWordRepositoryMock;
        private Mock<IRecognizer> _recognizerMock;

        public GetUnrecognizedWordsShould()
        {
            _mapperMock = new Mock<IMapper>();
            _lessonRepositoryMock = new Mock<ILessonRepository>();
            _exerciseRepositoryMock = new Mock<IExerciseRepository>();
            _unrecognizedWordRepositoryMock = new Mock<IUnrecognizedWordRepository>();
            _recognizerMock = new Mock<IRecognizer>();
            _adminPresentation = new AdminPresentation(_mapperMock.Object, _lessonRepositoryMock.Object,
                _exerciseRepositoryMock.Object, _unrecognizedWordRepositoryMock.Object, _recognizerMock.Object);
        }

        [Fact]
        public void ReturnMappedUnrecognizedWords()
        {
            var engPhrase = "no matter";
            var unrecognizedWords = new List<Word>();
            _recognizerMock.Setup(x => x.UnrecognizedWords).Returns(unrecognizedWords);
            var mappedUnrecognizedWords = new List<UnrecognizedWordVM>();
            _mapperMock.Setup(x => x.Map<IEnumerable<UnrecognizedWordVM>>(unrecognizedWords)).Returns(mappedUnrecognizedWords);

            var result = _adminPresentation.GetUnrecognizedWords(engPhrase);

            _recognizerMock.Verify(x => x.Recognize(engPhrase), Times.Once);
            _mapperMock.Verify(x => x.Map<IEnumerable<UnrecognizedWordVM>>(unrecognizedWords), Times.Once);
            Assert.Equal(result, mappedUnrecognizedWords);
        }
    }
}
