# ReFrame for rurune

ルルネ (rurune) 用の ReFrame です。アバターに入っている衣装・ギミックのうち **使わないものにチェックを入れるだけで、アップロード時に自動で取り除きます。** 元のアセットは書き換えません。

## 導入

1. VCC に ReFrame のリポジトリを追加します: <https://reframe.illusive-isc.jp/>
2. `ReFrame for rurune` をプロジェクトに追加します。共通部分の ReFrameCore は一緒に入ります。

## 使い方

1. Hierarchy で rurune を右クリック → **ReFrame → このアバターに ReFrame を追加**
2. `ReFrame` オブジェクトの Inspector で、使わない項目にチェックを入れます。チェックした項目は Scene と Hierarchy から消えて見えます。
3. いつもどおりアップロードします。

## 選べる項目

- **衣装・髪**: 髪・ヘッドホン / 服 / 髪留め / 下着 / 足 (ヒールオフ・ハイヒール) / 胸 / まとめ脱ぎ
- **ギミック**: ライトガン (蝶) / 撮影 / ペット (サメ) / パーティクル / ジャンプ・ダッシュ / AFK の水辺演出 / なで / 表情ロック / 噛みつき / 表情差分 / 胸サイズ
- **尻尾**: 尻尾 / 尻尾のリボン / 地面判定
- **エモート・姿勢**: エモート / 表情プリセット / AFK / 立ち・しゃがみ・伏せ・浮遊のポーズ / ロコモーション (ポーズ・身長)

## Quest 簡易対応版

Inspector 上部の **「Quest 簡易対応版を作成」** で Quest 用の設定が増えます。Quest で動かないコンポーネント・揺れ物・マテリアルをここで減らし、ビルドターゲットが Android のときに使われます。詳しくは ReFrameCore の README を見てください。

## ライセンス・連絡先

- [MIT License](LICENSE)
- 作者: illusive_isc — <https://x.com/illusive_isc>
- 配布物: <https://illusive-isc.booth.pm/>
