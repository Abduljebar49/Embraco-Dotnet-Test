
$(document).ready(function() {
  $('#search-input').on('input', function() {
    var query = $(this).val();
    if (query.trim() === '') {
      $('#search-results').empty();
      return;
    }
    $.ajax({
      url: '/umbraco/api/search/search',
      type: 'GET',
      data: { q: query },
      success: function(data) {
          console.log("data ;",data);
        var results = data.results;
        var listItems = '';
        results.forEach(function(result) {
          listItems += '<li>' + result.title + '</li>';
        });
        $('#search-results').html(listItems);
      },
      error: function(xhr, status, error) {
        console.log('Error:', error);
      }
    });
  });
});