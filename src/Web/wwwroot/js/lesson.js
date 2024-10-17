const answer = [];
const emptyAnswerPlaceholder = 'Переведите предложение';

renderAnswer();
renderGroup(0, 0);
renderGroup(1, 1);

function getWordGroupHtml(group) {
  let html = '';

  for (let i = 0; i < group.words.length; i++) {
    html += `<button type="button" class="btn btn-outline-secondary border-0 col pt-3 pb-3 js-word-button">${group.words[i]}</button>`;
  }

  return html;
}

$('.js-backspace').click(function() {
  const removedWord = answer.pop();
  renderAnswer();
  
  renderGroup(removedWord.groupContainerIndex, removedWord.groupIndex);
});

function renderAnswer() {
  const answerContainer = $('.js-answer');

  if (!answer.length) {
    answerContainer.text(emptyAnswerPlaceholder);
    return;
  }

  const result = answer.map(a => a.wordText).join(' ');

  answerContainer.text(result);
}

$(document).on('click', '.js-word-button', function () {
  const group = $(this).parent();
  const groupIndex = group.data('group-index');
  const groupContainerIndex = group.data('group-container-index')
  const wordText = $(this).text();

  const nextGroupIndex = getNextGroupIndex();
  
  answer.push({wordText, groupContainerIndex, groupIndex});
  renderAnswer();
  renderGroup(groupContainerIndex, nextGroupIndex);

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