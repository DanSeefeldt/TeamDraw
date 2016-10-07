var canvasSize = {"x":100,"y":500};

var DrawingCanvas = React.createClass({
  render: function() {
    return (
        <canvas className="main-canvas" id="myCanvas" height={this.props.canvasSize.x} width={this.props.canvasSize.y}/>
    );
  }
});

var MainPage = React.createClass({
    getInitialState: function() {
        return {canvasSize: {}};
    },
    componentDidMount: function() {
        var baseURL = "http://localhost:5000/api";
        var getCanvasUrl = baseURL + "/getCanvasSize"

        $.ajax({
            url: getCanvasUrl,
            dataType: 'json',
            cache: false,
            success: function(data) {
                this.setState({canvasSize: data});
            }.bind(this),
            error: function(xhr, status, err) {
                console.error(getCanvasUrl, status, err.toString());
            }.bind.this
        });
    },
    render: function() {
        return (
            <div className="main-page">
                <h1>Team Draw</h1>
                <DrawingCanvas canvasSize={this.state.canvasSize}/>
            </div>
        );
    }
});
ReactDOM.render(
  <MainPage />,
  document.getElementById('content')
);