function d21Tracking() {
    var self = this;

    self.fn = {
        track: function (_appName, _version, _domain) {
            var url = 'http://track.dirs21.local/api/Track/';
            var data = { ID: null, AppName: _appName, Version: _version, Domain: _domain };

            $.ajax({
                type: "POST",
                data: JSON.stringify(data),
                url: url,
                contentType: "application/json"
            });

            //$.ajax({
            //    type: "POST",
            //    url: url,
            //    data: JSON.stringify(data),
            //    success: function () {
            //        console.log('success');
            //    },
            //    dataType: 'json'
            //});
        }
    }
}

$(document).ready(function () {
        var d21Track = new d21Tracking();
        
        d21Track.fn.track("widgets","v2", "http://hotel-zum-test.de");
});