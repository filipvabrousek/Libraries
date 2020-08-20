## Runny Playlist migration
```swift
struct PlayListView: SwiftUI.View {
    var body: some SwiftUI.View {
            List(0..<100, id:\.self){ t in
                Text("Hello!")
            }
    }
}

class PlaylistController: UIViewController {
    override func viewDidLoad() {
        super.viewDidLoad()
        bottomPinSwiftUI(PlayListView(), top: 60, safe: false)
    }
 }
```
