const SparkPost = require('sparkpost');
const client = new SparkPost('<code>');

exports.handler = function(event, context, callback) {
  client.transmissions
    .send({
      content: {
        from: 'support@domaind.com',
        subject: 'Test',
        html: `<html>Hello World</html>`},
    recipients: [{ address: 'brunoj.santos91@gmail.com' }]
  })
  .then(response => {
    console.log('Mail has been sent successfully!')
    callback(null, {
      statusCode: successCode,
      headers,
      body: JSON.stringify(response),
    })
    console.log(response)
  })
  .catch(err => {
    console.log('Whoops! Something went wrong')
    console.log(err)
  });
}