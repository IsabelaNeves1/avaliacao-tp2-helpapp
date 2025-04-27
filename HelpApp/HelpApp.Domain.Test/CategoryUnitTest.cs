using HelpApp.Domain.Entities;
using FluentAssertions;
using Xunit;
using HelpApp.Domain.Validation;

namespace HelpApp.Domain.Test
{
    public class CategoryUnitTest
    {
        #region Testes Positivos
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }
        #endregion
        #region Testes Negativos
        [Fact(DisplayName ="Create Category With Name Empty")]
        public void CreateCategory_WithNameEmpty_ResultObjetcException()
        {
            Action action = () => new Category(1, "");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName ="Create Category With Name Too Long")]
        public void CreateCategory_WithNameTooLong_ResultObjectException()
        {
            string longName = new string('A', 256);
            Action action = () => new Category(longName);
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid name, too long, maximum 255 characters.");
        }
        #endregion
    }
}
