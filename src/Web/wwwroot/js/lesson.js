const words = [];
const emptyAnswerPlaceholder = 'Переведите предложение';

if (exerciseCompletedSuccessfully === null || exerciseCompletedSuccessfully) {
  renderAnswer();
}
renderGroup(0, 0);
renderGroup(1, 1);

function init() {
  $('.js-correct-answer:not(.d-none)').fadeOut('slow');
  // setTimeout(() => $('.js-correct-answer:not(.d-none)').addClass('d-none'), 500);
}

function getWordGroupHtml(group) {
  let html = '';

  for (let i = 0; i < group.words.length; i++) {
    html += `<button type="button" class="btn btn-outline-secondary border-0 col pt-3 pb-3 js-word-button">${group.words[i]}</button>`;
  }

  return html;
}

$('.js-backspace').click(function() {
  const removedWord = words.pop();
  
  if (!removedWord) {
    return;
  }
  
  renderAnswer();
  
  renderGroup(removedWord.groupContainerIndex, removedWord.groupIndex);
});

function renderAnswer() {
  const answerContainer = $('.js-answer');
  const backspaceButton = $('.js-backspace');

  if (!words.length) {
    answerContainer.text(emptyAnswerPlaceholder);
    backspaceButton.prop('disabled', true);
    return;
  }

  backspaceButton.prop('disabled', false);

  if (answerContainer.hasClass('text-danger')) {
    answerContainer.removeClass('text-danger');
  }

  const result = words.map(a => a.wordText).join(' ');

  answerContainer.text(result);
}

$(document).on('click', '.js-word-button', function () {
  const group = $(this).parent();
  const groupIndex = group.data('group-index');
  const groupContainerIndex = group.data('group-container-index')
  const wordText = $(this).text();

  const nextGroupIndex = getNextGroupIndex();
  
  words.push({wordText, groupContainerIndex, groupIndex});
  renderAnswer();
  renderGroup(groupContainerIndex, nextGroupIndex);
  
  if (words.length === groups.length) {
    completeExercise();
  }

  function getNextGroupIndex() {
    const groupIndexes = $('.js-group').map(function() {
      return $(this).data('group-index');
    }).get();

    return Math.max(...groupIndexes) + 1;
  }
});

function renderGroup(groupContainerIndex, groupIndex) {
  const groupContainer = $(`.js-group[data-group-container-index=${groupContainerIndex}]`);

  if (groupIndex < groups.length) {
    const html = getWordGroupHtml(groups[groupIndex]);
    groupContainer.html(html);
    groupContainer.data('group-index', groupIndex);
    groupContainer.removeClass('invisible');
    return;
  }

  const isLastGroup = groupIndex + 1 >= groups.length;
  if (isLastGroup) {
    groupContainer.addClass('invisible');
  } else {
    groupContainer.empty();
  }
}

function completeExercise() {
  const answer = words.map(w => w.wordText).join(' ');
  console.log(answer);
  $('.js-exercise-form-answer').val(answer);
  $('.js-exercise-form').submit();
}